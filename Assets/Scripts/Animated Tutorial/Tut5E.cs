using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut5E : MonoBehaviour
{
    public GameObject follow1;
    public GameObject follow2;
    public bool finish = false;
    public float tiempo = 0.75f;
    public GameObject thiss;
    Vector3 initialPos = new Vector3(-310, 8, 120);
    public AnimationClip tut5E;
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
        anim.clip = tut5E;
        anim.Play();
        finish = true;
		
    }

    public void temp()
    {
		
        if (tiempo <= 0)
        {
            thiss.SetActive(false);
            thiss.transform.position = initialPos;
            follow1.SetActive(true);
            follow2.SetActive(true);
            tiempo = 0.75f;
        }
		
    } 
}
