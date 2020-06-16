using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPaletteInst : MonoBehaviour
{

    private int spawnCount; 
    public Manager manager;
    Vector3 initialPos = new Vector3(-85, 0, 100);
    Vector3 secondPos = new Vector3(-85, -15, 100);
    // Start is called before the first frame update
    void Start()
    {
        spawnCount = 0;
        InstantiatePalette();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void InstantiatePalette()
    {
        for (int i=0; i <= 9; i++)
        {
            
                GameObject colorBox = GameObject.CreatePrimitive(PrimitiveType.Cube);
                colorBox.transform.localScale = new Vector3 (15, 15, 1);
                colorBox.GetComponent<Renderer>().material.color = Color.blue;
                spawnCount++;
                if (spawnCount <= 5)
                {
                    colorBox.transform.position = initialPos;
                    initialPos.x = initialPos.x + 15;
                }
                else
                {
                    colorBox.transform.position = secondPos;
                    secondPos.x = secondPos.x + 15;
                }
           
        }
    }
}
