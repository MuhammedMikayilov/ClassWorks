using System;
namespace ExtentionIndexer
{
    public static class ExtentionTask
    {
        public static void SameArr(this int[] arr, int[] arr1)
        {
            int[] sames = { };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr[i] == arr1[j])
                    {
                        Array.Resize(ref sames, sames.Length+1);
                        sames[sames.Length-1] = arr[i];
                        
                    }
                }
            }

            foreach (int item in sames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
