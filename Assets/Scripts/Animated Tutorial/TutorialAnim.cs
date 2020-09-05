using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialAnim : MonoBehaviour
{
	public bool sonar1 = true;
	public bool sonar2 = true;
	public float timer = 0.5f;
	public Sounds sonidos;
	public GameObject siguiente1;
	public GameObject siguiente2;
	public GameObject siguiente3;
	public GameObject comenzar;
	public int estado;
	


    // Start is called before the first frame update
    void Start()
    {
	    estado = 1;
	    
    }

    void Update()
    {
	    timer -= Time.deltaTime;
	    suena1();
	    suena2();
    }
    
	public void siguiente()
	{
		estado++;
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
				comenzar.SetActive(false);
				break;
			case 2:
				sonar1 = true;
				sonar2 = true;
				timer = 1f;
				siguiente1.SetActive(false);
				siguiente2.SetActive(true);
				siguiente3.SetActive(false);
				comenzar.SetActive(false);
				break;
			case 3:
				sonar1 = true;
				timer = 1f;
				siguiente1.SetActive(false);
				siguiente2.SetActive(false);
				siguiente3.SetActive(true);
				comenzar.SetActive(false);
				break;
			case 4:
				sonar1 = true;
				sonar2 = true;
				timer = 1f;
				siguiente1.SetActive(false);
				siguiente2.SetActive(false);
				siguiente3.SetActive(false);
				comenzar.SetActive(true);
				break;
		}
	}

	public void suena1()
	{
		if (timer <= 0 && sonar1 == true)
		{
			sonidos.SlideSound();
			sonar1 = false;
		}
	}

	public void suena2()
	{
		if (timer <= -0.3 && sonar2 == true)
		{
			sonidos.SlideSound();
			sonar2 = false;
		}
	}

	public void irColorPick()
	{
		SceneManager.LoadScene("ColorPick");
	}
}
