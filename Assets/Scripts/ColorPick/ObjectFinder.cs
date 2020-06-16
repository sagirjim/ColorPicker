using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFinder : MonoBehaviour
{
    
    public GameObject[] colorBoxes;
    public GameObject[] myColorBoxes;


    public void FindBoxes()
    {
        
        GameObject[] colorBoxes = GameObject.FindGameObjectsWithTag("ColorBox");
        for (int i=0; i<= colorBoxes.Length; i++)
        {
            myColorBoxes[i] = colorBoxes[i].gameObject;
        }
    }
}
