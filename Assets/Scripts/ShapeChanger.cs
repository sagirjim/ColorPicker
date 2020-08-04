using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject[] bloques;
    public bool estado;

    void Start()
    {
        estado = true;
       
    }

    public void Forma()
    {
        var cubeMesh = cube.GetComponent<MeshFilter>().mesh;
        var sphereMesh = sphere.GetComponent<MeshFilter>().mesh;
        
        bloques = GameObject.FindGameObjectsWithTag("ColorBox");
        if (estado)
        {
            for (int i = 0; i <= bloques.Length -1; i++)
            {
                bloques[i].GetComponent<MeshFilter>().mesh = sphereMesh;
            }
        }

        if (!estado)
        {
            for (int i = 0; i <= bloques.Length -1; i++)
            {
                bloques[i].GetComponent<MeshFilter>().mesh = cubeMesh;
            }
        }

        if (estado)
        {
            estado = !estado;
        }
        else
        {
            estado = true;
        }
    }

    
}
