using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;

public class TerrainGenerator : MonoBehaviour
{
  public int depth = 20;
  public int width = 512;
  public int height = 512;
  public float scale = 20f;
  List<string> alt = new List<string>();
  void Start()
  {
    using (var reader = new StreamReader("./Assets/datafile.csv"))
    {

      while (!reader.EndOfStream)
      {
        var line = reader.ReadLine();
        var values = line.Split(',');

        alt.Add(values[2]);
      }
    }

    Terrain terrain = GetComponent<Terrain>();
    terrain.terrainData = GenerateTerrain(terrain.terrainData);

  }

  TerrainData GenerateTerrain(TerrainData terrainData)
  {
    terrainData.size = new Vector3(width, depth, height);
    terrainData.SetHeights(0, 0, GenerateHeights());
    return terrainData;
  }

  float[,] GenerateHeights()
  {
    int idx = height;
    float[,] heights = new float[width, height];
    for (int x = 0; x < width; x++)
    {
      idx = (x + 1) * height;
      for (int y = 0; y < height; y++)
      {

        heights[x, y] = CalculateHeight(idx);
        idx--;

      }

    }
    return heights;
  }
  float CalculateHeight(int idx)
  {
    //float xCoord = lon[x];
    //float yCoord = lat[y];

    return float.Parse(alt[idx]);
  }
}
