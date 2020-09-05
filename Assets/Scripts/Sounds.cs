using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource sonidos;
	public AudioClip siguiente;
	public AudioClip atras;
	public AudioClip saltar;
	public AudioClip añadir;
	public AudioClip borrar;
	public AudioClip insertar;
	public AudioClip exportar;
	public AudioClip salir;
	public AudioClip cromatico;
	public AudioClip apply;
	public AudioClip pencil;
	public AudioClip pincel;
	public AudioClip slide;

	public void SiguienteSound() 
	{
		sonidos.PlayOneShot(siguiente);
	}
	public void AtrasSound() 
	{
		sonidos.PlayOneShot(atras);
	}
	public void SaltarSound() 
	{
		sonidos.PlayOneShot(saltar);
	}
	public void AñadirSound() 
	{
		sonidos.PlayOneShot(añadir);
	}
	public void BorrarSound() 
	{
		sonidos.PlayOneShot(borrar);
	}
	public void InsertarSound() 
	{
		sonidos.PlayOneShot(insertar);
	}
	public void ExportarSound() 
	{
		sonidos.PlayOneShot(exportar);
	}
	public void SalirSound() 
	{
		sonidos.PlayOneShot(salir);
	}
	public void CromaticoSound() 
	{
		sonidos.PlayOneShot(cromatico);
	}
	public void ApplySound() 
	{
		sonidos.PlayOneShot(apply);
	}
	public void PencilSound() 
	{
		sonidos.PlayOneShot(pencil);
	}
	public void PincelSound() 
	{
		sonidos.PlayOneShot(pincel);
	}
	public void SlideSound() 
	{
		sonidos.PlayOneShot(slide);
	}
}
