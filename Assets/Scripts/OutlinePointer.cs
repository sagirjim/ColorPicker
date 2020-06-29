using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlinePointer : MonoBehaviour
{

    public Camera cam;
    
   
    private OutlineController prevController;
    private OutlineController currentController;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
    
      //RayHover();      
        RayClicker();   
    }

    public void RayClicker()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit clickHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out clickHit, Mathf.Infinity))
            {
                if (clickHit.transform.CompareTag("ColorBox"))
                {
                    
                    currentController = clickHit.transform.GetComponent<OutlineController>();

                    if (prevController != currentController)
                    {
                        HideOutline();
                        ShowOutline();

                    }
                    prevController = currentController;
                }
                
            }
            
        }
    }

    /*private void RayHover()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (hit.transform)
            {
                currentController = hit.transform.GetComponent<OutlineController>();

                if (prevController != currentController)
                {
                    HideOutline();
                    ShowOutline();

                }
                prevController = currentController;
            }
            else
            {
                HideOutline();
            }
        }
        else
        {
            HideOutline();
        }
    }*/

    private void ShowOutline()
    {
        if (currentController != null)
        {
            currentController.ShowOutline();
        }
    }

    private void HideOutline()
    {
        if (prevController != null)
        {
            prevController.HideOutline();
            prevController = null;
        }
    }
}
