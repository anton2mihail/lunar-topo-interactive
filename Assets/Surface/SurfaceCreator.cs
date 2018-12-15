﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SurfaceCreator : MonoBehaviour
{

  private Mesh mesh;

  private void OnEnable()
  {
    if (mesh == null)
    {
      mesh = new Mesh();
      mesh.name = "Surface Mesh";
      GetComponent<MeshFilter>().mesh = mesh;
    }
    Refresh();
  }

  public void Refresh()
  {
    mesh.vertices = new Vector3[] {
      new Vector3(0f, 0f),
      new Vector3(1f, 0f),
      new Vector3(0f, 1f)
    };
    mesh.triangles = new int[] {
      0, 1, 2
    };
  }
}
