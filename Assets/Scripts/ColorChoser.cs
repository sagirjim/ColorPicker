using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChoser : MonoBehaviour
{
    public Color pickedColor;
    public GameObject Imagen;
    public Manager manager;
    

    void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Imagen = GameObject.FindGameObjectWithTag("destructible");
            RayForColor();
        }
        
    }

    public void RayForColor()
    {
        
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.CompareTag("Image"))
                {
                    
                    Renderer renderer = hit.transform.GetComponent<MeshRenderer>();
                    Texture2D tex = renderer.material.mainTexture as Texture2D;
                    pickedColor = tex.GetPixelBilinear(hit.textureCoord2.x, hit.textureCoord2.y);
                    Imagen.GetComponent<Renderer>().material.color = pickedColor;
                    
                }
            }
        
        
    }
}
