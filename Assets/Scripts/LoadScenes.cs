using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadScenes : MonoBehaviour
{
    public GameObject manager;
    public OutlineController Controller;
    public GameObject highlight;
    public GameObject cuadroColor;
    public GameObject drawColorPickers;
    public GameObject siguiente;
    public GameObject atras;
    public GameObject atras2;
    public GameObject exportar;
    public GameObject salir;
    public GameObject añadir;
    public GameObject borrar;
    public GameObject insertar;


    public void LoExportScreen()
    {
        HideOutline();

        manager.SetActive(false);
        cuadroColor.SetActive(false);
        drawColorPickers.SetActive(false);
        siguiente.SetActive(false);
        atras.SetActive(false);
        añadir.SetActive(false);
        borrar.SetActive(false);
        insertar.SetActive(false);
        atras2.SetActive(true);
        exportar.SetActive(true);
        salir.SetActive(true);
    }


    public void LoColorPickScreen()
    {
        manager.SetActive(true);
        cuadroColor.SetActive(true);
        drawColorPickers.SetActive(true);
        siguiente.SetActive(true);
        atras.SetActive(true);
        añadir.SetActive(true);
        borrar.SetActive(true);
        insertar.SetActive(true);
        atras2.SetActive(false);
        exportar.SetActive(false);
        salir.SetActive(false);
    }

    public void HideOutline()
    {
        highlight = GameObject.FindGameObjectWithTag("destructible");
        Controller = highlight.GetComponent<OutlineController>();
        if (Controller != null)
        {
            Controller.HideOutline();
            Controller = null;
        }
    }


}
