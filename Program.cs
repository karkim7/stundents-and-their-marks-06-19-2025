using System;








class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int count = int.Parse(Console.ReadLine());
        
        Student[] students = new Student[count];
        
        for (int i=0; i<count; i++)
        {
            Console.Write("Enter the id of the student: ");
            int id = int.Parse(Console.ReadLine());
            
            Console.Write("Enter name of the student: ");
            string name = Console.WriteLine();
            
            Console.Write("Enter number of subjects: ");
            int subjects = int.Parse(Console.WriteLine());
            
            int [] marks = int[subjects];
            for (int j=0; j<subjects; j++)
            {
                Console.Write($"Enter the marks {j+1} :  ");
                marks[j] = int.Parse(Console.ReadLine());
            }
            students[i] = new Student(id, name, marks);
        }
        Console.WriteLine("\n ---students progress report---");
        foreach(student s in students)
        {
            s.DisplayInfo();
        }
    }
}