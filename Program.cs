using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2d {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Jag:");
            Jag(); //1ms
            Console.WriteLine("Rectangle:");
            Rectangle(); //約10ms
            Console.WriteLine("List");
            lists(); //約15ms

            Console.ReadKey();
        }

        private static void Jag() {
            double[][] array = new double[4][];
            array[0] = new double[3];
            array[1] = new double[3];
            array[2] = new double[3];
            array[3] = new double[3];
            //ジャグ配列

            array[0][0] = 5.0d;
            array[1][2] = 1.0d;

            double a = array[1][2];
            Console.WriteLine(a);

            for(int i = 0; i < array.Length; i++) {
                for(int j = 0; j < array[i].Length; j++) {
                    Console.WriteLine($"{i}行{j}列:{array[i][j]}");
                }
            }
        }

        private static void Rectangle() {
            double[,] array = new double[4, 3];
            array[0, 0] = 5.0d;
            array[1, 2] = 1.0d;
            //矩形配列

            for(int i = 0; i < 4; i++) {
                for(int j = 0; j < 3; j++) {
                    Console.WriteLine($"{i}行{j}列:{array[i, j]}");
                }
            }
        }

        private static void lists() {
            List<List<double>> doubleList = new List<List<double>>();

            doubleList.Add(new List<double>() { 5.0d, 0.0d, 0.0d, 0.0d });
            doubleList.Add(new List<double>() { 0.0d, 0.0d, 1.0d, 0.0d });
            doubleList.Add(new List<double>() { 0.0d, 0.0d, 0.0d, 0.0d });
            doubleList.Add(new List<double>() { 0.0d, 0.0d, 0.0d, 0.0d });

            for(int i = 0; i < doubleList.Count; i++) {
                for(int j = 0; j < doubleList[i].Count; j++) {
                    Console.WriteLine($"{i}行{j}列:{doubleList[i][j]}");
                }
            }
        }
    }
}
