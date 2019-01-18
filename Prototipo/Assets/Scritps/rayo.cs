using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayo : MonoBehaviour
{

    RaycastHit2D hit;
    public LayerMask capas;
    public float distancia = 1;


    private void Update()
    {
        hit = Physics2D.Raycast(transform.position, transform.right, distancia, capas);
        if (hit)
        {
            Debug.DrawRay(transform.position, transform.right * distancia, Color.green);
            Debug.Log("he tocado" +hit);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.right * distancia, Color.red);
        }
    }
}
