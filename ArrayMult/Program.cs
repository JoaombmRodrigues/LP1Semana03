﻿using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz A e vetor b
            float [,] A = new float [2,2];
            float [] b = new float [2];

            //for para cada valor
            for(int i = 0; i <2; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    A[i,j]= float.Parse(args[i*2+j]);
                }
                b[i] = float.Parse(args[4+i]);
            }
        }
    }
}
