using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    private void Start()
    {
        CreateMap();
    }
    public void CreateMap()
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
    }
}
