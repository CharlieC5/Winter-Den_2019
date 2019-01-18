using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastreHabitacionRayos : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidad;
    public float velocidadTope;

    RaycastHit2D hit;
   
    public LayerMask capas;
    public float distancia = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  


    private void Update()
    {
        hit = Physics2D.Raycast(transform.position, transform.right, distancia, capas);
        if (hit)
        {
            Debug.DrawRay(transform.position, transform.right * distancia, Color.green);
            Debug.Log("he tocado" + hit);
            transform.Rotate(new Vector3(0, 180, 0));
        }
        else
        {
            Debug.DrawRay(transform.position, transform.right * distancia, Color.red);
        }

        
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Habitacion"))
        {
            if (Mathf.Abs(rb.velocity.x) < velocidadTope)
            {
                rb.AddForce(transform.right * velocidad);
            }
        }
    }
    
    

    private void OnMouseDrag()
    {
        gameObject.transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.5f);

    }


}
