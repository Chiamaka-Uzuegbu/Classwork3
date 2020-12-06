using System;
using System.Threading.Tasks;

namespace Classwork3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.RegisterStudent("490091");
            int k = p.SendEmails(5).Result;
            //Async / await program();
            DataStructures();
            Console.ReadLine();
        }

        public async Task<int> SendEmails(int noOfTimes)
        {
            int collation = 0;
            await Task.Run(() =>
            {

                for (int i = 0; i < noOfTimes; i++)
                {
                    System.Threading.Thread.Sleep(2000);
                    collation += 1;
                    Console.WriteLine($"email {i} is being sent");
                }
            });
            return collation;
        }
        public void RegisterStudent(string matricNo)
        {
            Console.WriteLine($"Student with matric no {matricNo} is registered ");
        }

        public static void DataStructures()
        {
            var numbers = new int[4];
            var myArray = Array.CreateInstance(typeof(string), 12, 9, 3);
            var multiarray = new int[4, 4];

            int[][] jaggedArray = new int[1][];

            int[,] array2D = new int[,]
            {
                { 1, 2 },
                { 3, 2 },
                { 5, 6 },
                { 5, 3 }
            };

            int[,,] array3D = new int[4, 3, 5]
            {
                {
                    { 2, 4, 4, 6, 4 }, { 4, 3, 3, 4, 4, }, { 4, 3, 3, 4, 4, }
                },
                {
                    { 2, 1, 2, 3, 4 }, { 2, 4, 5, 2, 1 }, { 4, 3, 2, 4, 4, }
                },
                {
                    { 2, 1, 3, 4, 5 }, { 2, 1, 4, 1, 5, }, { 4, 3, 1, 4, 4, }
                },
                {
                    { 3, 4, 5, 6, 2 }, { 2, 3, 5, 3, 2 }, { 4, 3, 2, 4, 4, }
                }
            };

            int[,,,] array4D = new int[3, 4, 2, 4]
            {
                {
                    {
                        { 2, 3, 3, 1 }, { 2, 3, 2, 1 }
                    },
                    {
                        { 2, 2, 3, 1 }, { 3, 2, 1, 3 }
                    },
                    {
                        { 2, 3, 4, 1 }, { 2, 3, 3, 1 }
                    },
                    {
                        { 2, 3, 3, 1 }, { 2, 3, 2, 1 }
                    }
                },
                {
                    {
                        { 2, 3, 4, 2 }, { 2, 3, 4, 3 }
                    },
                    {
                        { 2, 3, 5, 6 }, { 3, 4, 7, 3 }
                    },
                    {
                        { 3, 4, 2, 4, }, { 5, 3, 2, 4 }
                    },
                    {
                        { 2, 4, 5, 2 }, { 3, 4, 5, 2 }
                    }
                },
                {
                    {
                        { 3, 4, 5, 6 }, { 3, 5, 1, 2 }
                    },
                    {
                        { 4, 5, 1, 5 }, { 5, 2, 1, 7 }
                    },
                    {
                        { 4, 2, 1, 4 }, { 4, 1, 7, 3 }
                    },
                    {
                        { 2, 7, 2, 1 }, { 4, 1, 3, 2 }
                    }
                },
            };
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; i < array3D.GetLength(1); j++)
                {
                    for (int k = 0; i < array3D.GetLength(2); k++)
                        Console.Write($" {array3D[i, j, k]} ");
                }
            }
        }
    }
}


            




