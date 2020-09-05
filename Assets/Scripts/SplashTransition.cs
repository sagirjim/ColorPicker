using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTransition : MonoBehaviour
{
 	public float tiempo = 6f;

    void Update()
    {
		tiempo -= Time.deltaTime;
		if (tiempo <= 0) 
		{
			SceneManager.LoadScene("Presentacion");	
		}
    
    }
}
