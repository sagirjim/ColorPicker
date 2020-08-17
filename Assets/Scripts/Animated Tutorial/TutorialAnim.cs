using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialAnim : MonoBehaviour
{
	
	public GameObject siguiente1;
	public GameObject siguiente2;
	public GameObject siguiente3;
	public GameObject atras1;
	public GameObject atras2;
	public GameObject atras3;
	public GameObject comenzar;
	public int estado;
	


    // Start is called before the first frame update
    void Start()
    {
	    estado = 1;
    }
    
	public void siguiente()
	{
		estado++;
		Cambio();
	}

	public void atras()
	{
		estado--;
		Cambio();
	}
	
	public void Cambio() 
	{
		switch (estado)
		{
			case 1:
				siguiente1.SetActive(true);
				siguiente2.SetActive(false);
				siguiente3.SetActive(false);
				atras1.SetActive(true);
				atras2.SetActive(false);
				atras3.SetActive(false);
				comenzar.SetActive(false);
				break;
			case 2:
				siguiente1.SetActive(false);
				siguiente2.SetActive(true);
				siguiente3.SetActive(false);
				atras1.SetActive(false);
				atras2.SetActive(true);
				atras3.SetActive(false);
				comenzar.SetActive(false);
				break;
			case 3:
				siguiente1.SetActive(false);
				siguiente2.SetActive(false);
				siguiente3.SetActive(true);
				atras1.SetActive(false);
				atras2.SetActive(false);
				atras3.SetActive(true);
				comenzar.SetActive(false);
				break;
			case 4:
				siguiente1.SetActive(false);
				siguiente2.SetActive(false);
				siguiente3.SetActive(false);
				atras1.SetActive(false);
				atras2.SetActive(false);
				atras3.SetActive(false);
				comenzar.SetActive(true);
				break;
		}
	}
}
