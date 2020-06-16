using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public ColorPicker picker;
    public GameObject cambiable;
    public GameObject colorBlock;
    GameObject blockClone;
    public GameObject destrucible;
    public List<Vector3> Position = new List<Vector3>();
    public GameObject[] ColorBlocks;
    

    private int i = 0;

    private int blockCount;

    Vector3 Pos1F = new Vector3(-7, 11, 30);
    Vector3 Pos2F = new Vector3(-2, 11, 30);
    

    Vector3 Pos1 = new Vector3(-7, 6, 30);
    Vector3 Pos2 = new Vector3(-2, 6, 30);
    Vector3 Pos3 = new Vector3(-7, 1, 30);
    Vector3 Pos4 = new Vector3(-2, 1, 30);
    Vector3 Pos5 = new Vector3(-7, -4, 30);
    Vector3 Pos6 = new Vector3(-2, -4, 30);
    Vector3 Pos7 = new Vector3(-7, -9, 30);
    Vector3 Pos8 = new Vector3(-2, -9, 30);
    // Start is called before the first frame update
    void Start()
    {
        ColorBlocks = new GameObject[8];
        

        blockCount = 0;

        for (blockCount = 0; blockCount <= 1; blockCount++)
        {
            blockClone = Instantiate(colorBlock, transform.position, Quaternion.identity);
            switch (blockCount)
            {
                case 0:
                    blockClone.transform.position = Pos1F;
                    blockClone.layer = 9;
                    
                    break;
                case 1:
                    blockClone.transform.position = Pos2F;
                    blockClone.layer = 9;
                    
                    break;
                
            }
        }

        Position.Add(Pos1);
        Position.Add(Pos2);
        Position.Add(Pos3);
        Position.Add(Pos4);
        Position.Add(Pos5);
        Position.Add(Pos6);
        Position.Add(Pos7);
        Position.Add(Pos8);



    }
    // Update is called once per frame
    void Update()
    {
      
        
    }

    public void colorBlockSpawn()
    {
        
        
        if (blockCount <= 9)
        {
            for (i = 0; i <= ColorBlocks.Length; i++)
            {
                if (ColorBlocks[i] == null)
                {
                    blockClone = Instantiate(colorBlock, Position[i], Quaternion.identity);
                    ColorBlocks[i] = blockClone;
                    
                    blockCount++;
                    break;
                }
            }
        } 
    }

    public void eraseBlock()
    {
        GameObject destructible = GameObject.FindGameObjectWithTag("destructible");
        if (destructible != null && destructible.layer != 9)
        {
            
            Destroy(destructible);
            blockCount--;
            
        } 
    }

    
}
