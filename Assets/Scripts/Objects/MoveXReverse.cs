﻿using UnityEngine;
using System.Collections;

public class MoveXReverse : MonoBehaviour
{

    Rigidbody Platform;
    float i;
    float timer = 0;
    public float moveDistance;
    float waitTime;

    // Use this for initialization
    void Start()
    {

        Platform = GetComponent<Rigidbody>();
        i = -0.10f;
        waitTime = moveDistance + 100;

    }

    // Update is called once per frame
    void Update()
    {

        timer += 1;

        if (timer < moveDistance)
        {
            transform.position += new Vector3(-i, 0, 0);
        }
        else if (timer < waitTime)
        {
            Platform.velocity = Vector3.zero;
            Platform.angularVelocity = Vector3.zero;
        }
        else
        {
            i *= -1;
            timer = 0;
        }
    }



}