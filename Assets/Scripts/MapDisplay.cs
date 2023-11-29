using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    int width = 1000;
    int height = 1000;
    public int seed = 10;
    public float[,] noiseArray = null;
    public void Start()
    {
        GenerateTex();
    }

    public void GenerateTex()
    {
        noiseArray = new float[width, height];
        noiseArray = Noise.GenerateNoiseMap(width, height, seed);
        SetTerrainTexture(width, height, noiseArray);

    }

    public void SetTerrainTexture(int width,int height, float[,] arrayData)
    {
        Texture2D texture2D = new Texture2D(width,height);
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                float data = arrayData[i, j];
                
                Color color = Color.Lerp(Color.blue, Color.green, data);
                texture2D.SetPixel(i, j, color);
               
            }
        }
        texture2D.Apply();
        // GetComponent<MeshRenderer>().material.SetTexture("_MainTex", texture2D);
        GetComponent<Terrain>().materialTemplate.SetTexture("_MainTex", texture2D);
    }
}
