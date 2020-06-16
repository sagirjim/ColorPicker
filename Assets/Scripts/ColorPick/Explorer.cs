﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using SmartDLL;
using System.IO;



public class Explorer : MonoBehaviour
{
    public GameObject eImage;
    public Button openExplorerButton;
    private bool readImage = false;

    public SmartFileExplorer fileExplorer = new SmartFileExplorer();

    void OnEnable()
    {
        openExplorerButton.onClick.AddListener(delegate { ShowExplorer(); });
    }

    void Update()
    {
        if (fileExplorer.resultOK && readImage)
        {
            OpenImage(fileExplorer.fileName);
            readImage = false;
        }
    }

    void ShowExplorer()
    {
        string initialDir = @"C:\";
        bool restoreDir = true;
        string title = "Open a Image File";
        string defExt = "png";
        string filter = "txt files (*.png)|*.png";
        fileExplorer.OpenExplorer(initialDir, restoreDir, title, defExt, filter);
        readImage = true;
    }



    void OpenImage(string path)
    {
        WWW www = new WWW("file:///" + path);
        eImage.GetComponent<Renderer>().material.mainTexture = www.texture;
    }




}
