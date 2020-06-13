using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
       // Start is called before the first frame update
   
    public float fuerza = 1f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + -rb.position * fuerza * Time.fixedDeltaTime);
    }
 

     void OnTriggerEnter() {
        Destroy(gameObject);

    }
}
