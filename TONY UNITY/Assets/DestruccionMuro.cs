﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionMuro : MonoBehaviour
{


    Animator anim;
    public static int puntajeMinimo = 330;
    float secondsCounter = 0;
    float secondsToCount = 0.5f;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if (GameController.Score >=puntajeMinimo)
        {
            Debug.Log("entre al if");
            secondsCounter += Time.deltaTime;

            anim.SetTrigger("destruido");

            if (secondsCounter >= secondsToCount)
            {
                
                Destroy(gameObject);       
            }
        }

    }
}
