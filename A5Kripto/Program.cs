﻿using System;

namespace A5Kripto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] J = { 0, 0, 0, 0, 1, 0, 1, 0 };
            //int[] J = { 0,1,0,0,0,1,1,0};
            int[] C = new int[J.Length];
            Random rand = new Random();
                int[] x = { 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0 };
                int[] y = { 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0 };
                int[] z = { 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1 };
            
            #region
            //int[] x = new int[19];
            //int[] y = new int[22];
            //int[] z = new int[23];

            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i]= rand.Next(0,2);
            //}
            //for (int i = 0; i < y.Length; i++)
            //{
            //    y[i]= rand.Next(0,2);
            //}
            //for (int i = 0; i < z.Length; i++)
            //{
            //    z[i]= rand.Next(0,2);
            //}
            #endregion

            while (count < 8)
            {
                int[] M0 = { x[7], y[9], z[9] };
                int a0 = 0;
                int a1 = 0;

                for (int j = 0; j < M0.Length; j++)
                {
                    if (M0[j] == 1) a1++;
                    else a0++;
                }
                int sdvig = a1 > a0 ? 1 : 0;


                int X;
                X = (x[18] + x[17]) == 1 ? 1 : 0;
                X = (X + x[16]) == 1 ? 1 : 0;
                X = (X + x[13]) == 1 ? 1 : 0;

                int Y;
                Y = (y[21] + y[20]) == 1 ? 1 : 0;

                int Z;
                Z = (z[22] + z[21]) == 1 ? 1 : 0;
                Z = (Z + z[20]) == 1 ? 1 : 0;

                if (M0[0] == sdvig) { x = ShiftArrayRight(x, X); Console.Write("x "); }
                if (M0[1] == sdvig) { y = ShiftArrayRight(y, Y); Console.Write("y "); }
                if (M0[2] == sdvig) {z = ShiftArrayRight(z, Z); Console.Write("z "); }
                Console.WriteLine();

                int k;
            k = (x[18] + y[21]) == 1 ? 1 : 0;
            k = (k + z[22]) == 1 ? 1 : 0;


            C[count] = (J[count] + k) == 1 ? 1 : 0;
            count++;

            }
            foreach (var item in C)
            {
                Console.Write(item+" ");
            }





        }
        static int[] ShiftArrayRight(int[] arr,int X)
        {
            if (arr.Length < 2)
            {
                return arr; 
            }


            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1]; 
            }

            arr[0] = X; 
            return arr;
        }
    }
}