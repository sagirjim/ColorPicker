using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public ColorChoser colorPicker;
    public GameObject cambiaso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cambiaso = GameObject.FindGameObjectWithTag("destructible");
    }

    public void ColorChange()
    {
        if (cambiaso.CompareTag("destructible"))
        {
            Color actualColor = this.gameObject.GetComponent<Color>();
            actualColor = colorPicker.pickedColor;
        }
    }
}
