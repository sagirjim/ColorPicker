﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut7E : MonoBehaviour
{
    public bool finish = false;
    public float tiempo = 0.75f;
    public GameObject thiss;
    Vector3 initialPos = new Vector3(290, -20, 120);
    public AnimationClip tut7E;
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
        anim.clip = tut7E;
        anim.Play();
        finish = true;
		
    }

    public void temp()
    {
		
        if (tiempo <= 0)
        {
            thiss.SetActive(false);
            thiss.transform.position = initialPos;
            tiempo = 0.75f;
        }
		
    } 
}