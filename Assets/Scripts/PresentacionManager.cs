using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PresentacionManager : MonoBehaviour
{
	private float stime = 0.3f;
	private bool sbool = true;
	public Sounds sonidos;
	private float time = 4f;
	private bool botonCom = false;
    public GameObject colorPick;
    public GameObject and;
    public GameObject draw;
    public GameObject pincel;
    public GameObject comenzar;
    public GameObject tutorial;
    public GameObject picker;
    public GameObject lienzo;
    public GameObject salir;
    
	void Start()
	{
		
	}

	void Update()
	{
		time -= Time.deltaTime;
		stime -= Time.deltaTime;
		if (time <= 0 && botonCom == false)
		{
			botonComenzar();
		}
		if (stime <= 0 && sbool == true)
		{
			sonidos.PencilSound();
			sbool = false;
		}
	}

	public void empezar()
	{
		colorPick.SetActive(false);
		comenzar.SetActive(false);
		and.SetActive(false);
		draw.SetActive(false);
		pincel.SetActive(false);
		tutorial.SetActive(true);
		picker.SetActive(true);
		lienzo.SetActive(true);
		salir.SetActive(true);
	}

	public void botonComenzar()
	{
		comenzar.SetActive(true);
		botonCom = true;
	}

	public void irTutorial()
	{
		SceneManager.LoadScene("Tutorial");	
	}

	public void irColorPick()
	{
		SceneManager.LoadScene("ColorPick");	
	}

	public void irLienzo()
	{
	
	}

	public void exit()
	{
		Application.Quit();
	}

}
