using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
   public GameObject tutorial1;
   public GameObject tutorial2;
   public GameObject tutorial3;
   
   void start() 
   {
        tutorial1.SetActive(true);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
   }
   
   public void Tutorial2Screen()
	{
		tutorial1.SetActive(false);
        tutorial2.SetActive(true);
		tutorial3.SetActive(false);
	}

	public void Tutorial3Screen()
	{
		tutorial1.SetActive(false);
        tutorial2.SetActive(false);
		tutorial3.SetActive(true);
	}

	public void Tutorial1Screen()
	{
		tutorial1.SetActive(true);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
	}

	public void IrHerramienta()
	{
		SceneManager.LoadScene("ColorPick");
	}
}
