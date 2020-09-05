using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRelocate : MonoBehaviour
{
    public GameObject colorBlock;
    public int i;
    private Vector3 newPos = new Vector3();
    public GameObject[] relocation = new GameObject[8];
    
    void Start()
    {
        for (i = 0; i <= relocation.Length -1; i++)
        {
            colorBlock = GameObject.Find("PickedColorCube(Clone)");
            relocation[i] = colorBlock;
            newPos = colorBlock.transform.position;
            if (colorBlock.tag == "ColorBox")
            {
                newPos.x -= 15;
                newPos.y += 3;
                colorBlock.transform.position = newPos;
                colorBlock.tag = "ColorBox2";
                
            }
        }
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
