using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float fuerza = 40f;
    private Rigidbody rb;
    public GameObject script;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward, ForceMode.Impulse);
    }
 

     void OnTriggerEnter() {
        Destroy(gameObject);
        bool a = GameObject.Find("gameMaster").GetComponent<manager>().bandera = true;
    }
}
