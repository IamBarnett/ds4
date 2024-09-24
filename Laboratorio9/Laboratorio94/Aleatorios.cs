﻿using System;

namespace laboratorio94
{
    public class Aleatorios
    {
        private Random random;

        public Aleatorios()
        {
            random = new Random();
        }

        public int GenerarNumero(int min, int max)
        {
            return random.Next(min, max + 1); 
        }

        public int[] GenerarArreglo(int min, int max, int cantidad)
        {
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }
            return arreglo;
        }
    }
}

