using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelLibrary.SpreadSheet;

namespace _13.LINQtoExcel
{
    class LINQtoExcel
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            List<string> columnNames = new List<string>();

            using (StreamReader reader = new StreamReader("..//..//Students-data.txt"))
            {
                string input = reader.ReadLine();
                columnNames = input.Split('\t').ToList();
                columnNames.Add("Result");

                while (true)
                {
                    input = reader.ReadLine();

                    if (input == null) break;

                    string[] result = input.Split('\t');

                    Student student = new Student();
                    student.Id = int.Parse(result[0]);
                    student.FirstName = result[1];
                    student.LastName = result[2];
                    student.Email = result[3];
                    student.Gender = result[4];
                    student.StudentType = result[5];
                    student.ExameResult = int.Parse(result[6]);
                    student.HomeworkSent = int.Parse(result[7]);
                    student.HomeworkEvaluated = int.Parse(result[8]);
                    student.TeamworkScore = decimal.Parse(result[9]);
                    student.AttendancesCount = decimal.Parse(result[10]);
                    student.Bonus = decimal.Parse(result[11]);
                    student.CalculateResult();
                    students.Add(student);
                }
            }

            var onlineStudents = students.Where(x => x.StudentType == "Online").OrderByDescending(x => x.Result).ToList();
            
            ExportToExcell(onlineStudents, columnNames);
        }

        public static void ExportToExcell(List<Student> students, List<string> columns)
        {
            string file = "..//..//results.xls";
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("Students");

            for (int i = 0; i < columns.Count; i++)
            {
                worksheet.Cells[0, i] = new Cell(columns[i]);
            }
            int col = 0;
            int row = 1;

            foreach (var student in students)
            {
                worksheet.Cells[row, col++] = new Cell(student.Id);
                worksheet.Cells[row, col++] = new Cell(student.FirstName);
                worksheet.Cells[row, col++] = new Cell(student.LastName);
                worksheet.Cells[row, col++] = new Cell(student.Email);
                worksheet.Cells[row, col++] = new Cell(student.Gender);
                worksheet.Cells[row, col++] = new Cell(student.StudentType);
                worksheet.Cells[row, col++] = new Cell(student.ExameResult);
                worksheet.Cells[row, col++] = new Cell(student.HomeworkSent);
                worksheet.Cells[row, col++] = new Cell(student.HomeworkEvaluated);
                worksheet.Cells[row, col++] = new Cell(student.TeamworkScore);
                worksheet.Cells[row, col++] = new Cell(student.AttendancesCount);
                worksheet.Cells[row, col++] = new Cell(student.Bonus);
                worksheet.Cells[row, col++] = new Cell(student.Result);
                col = 0;
                row++;
            }

            worksheet.Cells.ColumnWidth[0, 2] = 3000;
            worksheet.Cells.ColumnWidth[3] = 8500;
            worksheet.Cells.ColumnWidth[4, (ushort)columns.Count] = 4000;
            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);
        }
    }
}
