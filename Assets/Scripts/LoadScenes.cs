using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void LoExportScreen()
    {
        SceneManager.LoadScene(1);
    }

    public void LoColorPickScreen()
    {
        SceneManager.LoadScene(0);
    }


}
