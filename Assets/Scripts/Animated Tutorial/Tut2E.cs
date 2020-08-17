using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut2E : MonoBehaviour
{
	public GameObject follow;
	public bool finish = false;
	public float tiempo = 0.75f;
	public GameObject thiss;
    Vector3 initialPos = new Vector3(257, -27, 120);
    public AnimationClip tut2E;
    private Animation anim;
    
    void Start()
    {
        anim = GetComponent<Animation>();
    }

	void Update()
	{
		if (finish)
		{
			tiempo -= Time.deltaTime;
		}
		temp();
	}
    
    public void Next()
    {
        anim.clip = tut2E;
        anim.Play();
		finish = true;
    }

	public void temp()
	{
		
		if (tiempo <= 0)
		{
			thiss.SetActive(false);
			thiss.transform.position = initialPos;
			follow.SetActive(true);
			tiempo = 0.75f;
		}
		
	} 
}
