using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static float[,] GenerateNoiseMap(int width, int height,int seed)
    {
        Random.InitState(seed);
        float rnd = Random.Range(-width, width);
        float[,] array = new float[width,height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
               
                float xValue =rnd + ( i / (float)width) ;
                float yValue = rnd + ( j / (float)height) ;
                array[i, j] = Mathf.PerlinNoise(xValue *10 , yValue *10 );
            }
        }
        return array;
    }
}
