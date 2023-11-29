using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] Material materialTerrain;
    GameObject _terrain;
    bool isDone = false;

    public void CreateMap()
    {
        //create a new terrain data
        TerrainData _terrainData = new TerrainData();
        
        _terrainData.heightmapResolution = 1025;
        _terrain = Terrain.CreateTerrainGameObject(_terrainData);
        _terrain.GetComponent<Terrain>().materialTemplate = materialTerrain;
        _terrain.AddComponent<MapDisplay>();
    }

    public void Create3DMap()
    {
        _terrain.GetComponent<MapDisplay>().GenerateTex();
        float[,] map = _terrain.GetComponent<MapDisplay>().noiseArray;
        _terrain.GetComponent<Terrain>().terrainData.size = new Vector3(1000,100 ,1000);
        _terrain.GetComponent<Terrain>().terrainData.SetHeights(0,0, map);

    }

    private void Update()
    {
        if (!isDone)
        {
            CreateMap();
            Create3DMap(); 
            isDone = true;
        }
    }
}
