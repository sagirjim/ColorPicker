using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PaintIn3D;

public class LienzoCP : MonoBehaviour
{
    public Color pickedColor;
    public GameObject colorButton;

    public P3dPaintSphere pincelColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayForColor();
            Changer();
        }
    }

    public void RayForColor()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.transform.CompareTag("ColorBox2"))
            {

                pickedColor = hit.transform.GetComponent<Renderer>().material.color;
                
            }
        }
    }

    public void Changer()
    {
        colorButton = GameObject.Find("Color");
        colorButton.GetComponent<Image>().color = pickedColor;
        pincelColor.Color = pickedColor;
    }
}
