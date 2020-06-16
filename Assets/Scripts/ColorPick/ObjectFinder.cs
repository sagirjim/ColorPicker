using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFinder : MonoBehaviour
{
    public OutlineController esconder;
    public GameObject[] colorBoxes;



    public void FindBoxes()
    {
        
        GameObject[] colorBoxes = GameObject.FindGameObjectsWithTag("ColorBox");
    }
}
