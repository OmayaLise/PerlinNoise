using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    GameObject plane;
    private void Start()
    {
        CreateMap();
        Create3DMap();
    }
    public void CreateMap()
    {
        plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
    }

    public void Create3DMap()
    {
        //Vector3[] vertices = plane.GetComponent<MeshFilter>().mesh.vertices;

        //for (int i = 0; i < Noise.GenerateNoiseMap(3, 3).Length; i++)
        //{
        //    for (int j = 0;j < Noise.GenerateNoiseMap(3, 3).Length; j++)
        //        vertices[i].y= Noise.GenerateNoiseMap(3, 3)[i,j];
        //}

        //plane.GetComponent<MeshFilter>().mesh.vertices = vertices;
        //plane.GetComponent<MeshFilter>().mesh.RecalculateNormals();

    }
}
