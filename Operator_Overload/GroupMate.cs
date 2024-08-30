using System;



namespace Operator_Overload
{

    public class GroupMate
	{
		private Student[] students;
        private int count;

        public GroupMate(int n)
		{
			students = new Student[n];
			count = 0;
		}


		public void AddStudent(Student student)
		{
			if (count < students.Length)
			{
                students[count++] = student;
            }
			else
			{
				Console.WriteLine("Qrup doludur");
			}
		}
        public void Sort()
        {

            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i] < students[j])
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }



        public void GetStudents()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}

