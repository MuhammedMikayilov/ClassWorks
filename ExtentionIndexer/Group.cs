using System;
namespace ExtentionIndexer
{
    public class Group
    {
        public int MaxCount;

        public Student[] Student { get; }

        public Group(int maxCount)
        {
            Student = new Student[maxCount];
        }

        public Student this[int index]
        {
            get
            {
                try
                {
                    return Student[index];

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Kifayet qeder yer yoxdur");

                }
                return null;
            }
            set
            {
                
                try
                {

                    Student[index] = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Kifayet qeder yer yoxdur");
                }
            }

        }

        
    }
}
