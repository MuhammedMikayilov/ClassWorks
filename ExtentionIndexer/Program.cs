using System;

namespace ExtentionIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Student s1 = new Student("Muhammed", "Mikayilov", 20);
            //Student s2 = new Student("Vasif", "Xammedov", 37);

            //Group group = new Group(20);

            //group[1] = s1;
            //group[2] = s2;
            //Console.WriteLine(group[1]);
            #endregion

            #region Task 2
            int[] arr = { 0, 1, 2, 3, 4, 5, 6 };
            int[] arr1 = { 0, 1, 3 };

            arr.SameArr(arr1);
            #endregion



        }
    }
}
