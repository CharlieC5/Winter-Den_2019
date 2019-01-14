﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastreHabitacionLRC : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidad;
    public float velocidadTope;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Habitacion"))
        {
            if (rb.velocity.x < velocidadTope || rb.velocity.x >-velocidadTope)
            {
                rb.AddForce(new Vector2(1, 0) * velocidad);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Pared"))
        {
            velocidad = velocidad *-1;
        }
    }

}
