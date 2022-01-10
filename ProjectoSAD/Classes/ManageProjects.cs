using ProjectoSAD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ProjectoSAD.ManageProjects
{
    public class ManageProjects
    {
        public long ProjectId { get; set; }

        public int[] AtrWeight;
        public ManageProjects(long projectId)
        {
            dwfDataContext projeto = new dwfDataContext();
            ProjectId = projectId;
            //array com os pesos dos atributos
            AtrWeight = projeto.attributes.Where(s => s.project_id == ProjectId).OrderBy(a => a.id).Select(s => s.weight).ToArray();
        }

        //lista de alunos com todos os dados necessarios
        //nome, escola, n_escola, ... (classe Aluno)
        public List<Aluno> getStudentData() {

            dwfDataContext projeto = new dwfDataContext();

            List<student_project> students = projeto.student_projects.Where(s => s.project_id == ProjectId).OrderBy(s => s.student_id).ToList();

            int studentsCount = projeto.student_projects.Where(s => s.project_id == ProjectId).OrderBy(s => s.student_id).Count();

            Debug.WriteLine(studentsCount);
            Debug.Flush();


            List<Aluno> alunos = new List<Aluno>();

            double[] saatyIndex = new double[studentsCount];

            //obter valores necessarios para o calculo do indice saaty
            projeto.attributes.Where(s => s.project_id == ProjectId).OrderBy(a => a.id).ToList().ForEach(atribute => {

                int[] val = projeto.student_attributes.Where(sa => sa.attribute_id == atribute.id).OrderBy(sa => sa.student_id).Select(sa => sa.student_evaluation).ToArray();

                double[] weightsMatrix = this.weightsMatrix(val, studentsCount);

                double[] valNormalized = this.weightsMatrix();

                int indexI = 0;

                students.ForEach(student =>
                {

                    for (int i = 0; i < valNormalized.Length; i++)
                    {
                        saatyIndex[indexI] += (double)valNormalized[i] * (double)weightsMatrix[indexI];
                    }

                    indexI++;

                });
            });

            //atribuir indice saaty a cada aluno
            int indexJ = 0;
            students.ForEach(student => {
                double saatyIndexVal = Math.Round(saatyIndex[indexJ] / saatyIndex.Sum(), 3);
                int[] valStudent = projeto.student_attributes.Where(sa => sa.student_id == student.student_id).OrderBy(sa => sa.attribute_id).Select(sa => sa.student_evaluation).ToArray();

                student dadosAluno = projeto.students.Where(s => s.id == student.student_id).FirstOrDefault();


                alunos.Add(
                new Aluno(dadosAluno.name,
                dadosAluno.student_number,
                dadosAluno.email,saatyIndexVal, dwfPoints(valStudent, AtrWeight)));
                indexJ++;
            });

            List<Aluno> alunosOrdenados = alunos.OrderByDescending(aluno => aluno.DwfPoints).OrderByDescending(aluno => aluno.SaatyIndex).ToList();
            return alunosOrdenados;
        }

        //lista de atributos ordenados
        public List<attribute> getAtributeData() {
            dwfDataContext projeto = new dwfDataContext();

            return projeto.attributes.Where(s => s.project_id == ProjectId).OrderBy(a => a.id).ToList();
        }

        //execucao de todas as funcoes necessarias para retornar
        //os valores necesssarios para o calculo final
        public double[] weightsMatrix()
        {

            int[,] weightsMatrix = new int[AtrWeight.Length, AtrWeight.Length];

            for (int i = 0; i < AtrWeight.Length; i++)
            {
                for (int j = 0; j < AtrWeight.Length; j++)
                {
                    weightsMatrix[i, j] = AtrWeight[i] - AtrWeight[j];
                }
            }

            return convertMatrix(weightsMatrix);

        }

        //normalizar matriz qualitativa - diferença entre os atributos
        public double[] weightsMatrix(int[] AtrWeight, int studentCount) {

            int[,] weightsMatrix = new int[AtrWeight.Length, studentCount];

            for (int i = 0; i < AtrWeight.Length; i++)
            {
                for (int j = 0; j < studentCount; j++)
                {
                    weightsMatrix[i, j] = AtrWeight[i] - AtrWeight[j];
                }
            }

            return convertMatrix(weightsMatrix);

        }

        //converter matriz qualitativa (1,2,3,4,5) para escala de saaty
        public double[] convertMatrix(int[,] matrix) {

            double[,] convertedMatrix = new double[matrix.GetLength(0),matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    convertedMatrix[i,j] = normalizeValue(matrix[i, j]);
                }

            }

            double[] valuesInLine = new double[convertedMatrix.GetLength(1)];

            double sum = 0;
            for (int i = 0; i < valuesInLine.Length; i++)
            {
                double notNormalizedValue = getRowValue(GetRow(convertedMatrix, i));
                valuesInLine[i] = notNormalizedValue;
                sum += notNormalizedValue;
            }

            for (int i = 0; i < valuesInLine.Length; i++)
            {
                double temp = valuesInLine[i];
                valuesInLine[i] = temp / sum;
            }

            return valuesInLine;

        }

        //normalizar valor da linha
        public double getRowValue(double[] row) { 

        double rowValue = 1;

        for (int i = 0; i < row.Length; i++)  {
                rowValue *= row[i];
        }

        double exp = 1 / (double)row.Length;

        return Math.Pow(rowValue, exp); ;

        }

        //converter para escala de saaty
        public double normalizeValue(int weightNotNormalized) { 
            switch (weightNotNormalized)
            {
                case 4:
                    return 9;
                case 3:
                    return 7;
                case 2:
                    return 5;
                case 1:
                    return 3;
                case 0:
                    return 1;
                case -1:
                    return (double)1 / (double)3;
                case -2:
                    return (double)1 / (double)5;
                case -3:
                    return (double)1 / (double)7;
                case -4:
                    return (double)1 / (double)9;
                default:
                    return 1;
            }
        }

        //obter array 1D de uma array 2D
        public double[] GetRow(double[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }

        //criterio de desempate - pontos dwf
        public int dwfPoints(int[] val, int[] matrix) {
            int max = 0;
            int atual = 0;

            for (int i = 0; i < val.Length; i++) {
                max += 5 * matrix[i];
                atual += val[i] * matrix[i];
            }

            int returnVal = (int)Math.Ceiling(((double)atual / (double)max) * (double)100);

            return returnVal;
        }
    }


}
