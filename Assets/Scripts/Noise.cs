using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static float[,] GenerateNoiseMap(int width, int height)
    {
        float[,] array = new float[width,height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                array[i, j] = Mathf.PerlinNoise(i, j);
            }
        }
        return array;
    }
}
