using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PincelsControl : MonoBehaviour
{
    public GameObject pincelNormal;
	public GameObject pincelTextura;

	public void PincelNormalCambio() 
	{
		pincelNormal.SetActive(true);
		pincelTextura.SetActive(false);
	}

	public void PincelTexturaCambio() 
	{
		pincelNormal.SetActive(false);
		pincelTextura.SetActive(true);
	}

}
