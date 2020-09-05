using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{
    
    private MeshRenderer renderer;
    public float maxOutlineWidth;
    public Color OutlineColor;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowOutline()
    {
        renderer.material.SetFloat("_Outline", maxOutlineWidth);
        gameObject.tag = "destructible";
        ColorPicker cp = FindObjectOfType<ColorPicker>();
        cp.receiver = gameObject;

    }

    public void HideOutline()
    {
        renderer.material.SetFloat("_Outline", 0f);
        gameObject.tag = "ColorBox";
        
    }
}
