using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : MonoBehaviour
{
    public OutlineController Controller;
    public GameObject highlight;
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
        HideOutline();
        
        var cubeMesh = cube.GetComponent<MeshFilter>().mesh;
        var sphereMesh = sphere.GetComponent<MeshFilter>().mesh;
        
        bloques = GameObject.FindGameObjectsWithTag("ColorBox");
        if (estado)
        {
            for (int i = 0; i <= bloques.Length -1; i++)
            {
                bloques[i].GetComponent<MeshFilter>().mesh = cubeMesh;
            }
        }

        if (!estado)
        {
            for (int i = 0; i <= bloques.Length -1; i++)
            {
                bloques[i].GetComponent<MeshFilter>().mesh = sphereMesh;
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
    
    public void HideOutline()
    {
        highlight = GameObject.FindGameObjectWithTag("destructible");
        if (highlight != null)
        {
            Controller = highlight.GetComponent<OutlineController>();
            if (Controller != null)
            {
                Controller.HideOutline();
                Controller = null;
            }
        }
        
    }

    
}
