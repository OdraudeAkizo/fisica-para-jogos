﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovendoPlayer : MonoBehaviour
{
    Animator animator;
    float axis;
    Vector2 vel;
    bool ladoD = true;
    public float MaxVel = 10;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator> ();
        
    }
    void FixedUpdate()
    {
        axis = Input.GetAxis("Horizontal");
        if (axis > 0 && !ladoD)
            Vire();
        if (axis < 0 && ladoD)
            Vire();
        vel = new Vector2(axis * MaxVel, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = vel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Vire()
    {
        ladoD = !ladoD;
            Vector2 novoScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        transform.localScale = novoScale;
    }
}