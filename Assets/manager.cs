using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject cubo;
    public GameObject esfera;
    public Transform inicial;
    public bool bandera = false;
    void Start()
    {
        esfera = GameObject.Find("esfera");
        inicial = GameObject.Find("inicial").transform;
    }

    // Update is called once per frame;
    void Update()
    {
         if (bandera)
        {
            crearEsfera();
            bandera = false;
        }
    }

    public void fuego(){
        cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(inicial.position.x, inicial.position.y, inicial.position.z);
        cubo.AddComponent<Rigidbody>();
        cubo.AddComponent<cubo>();
      
    }

    public void crearEsfera(){
        esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esfera.transform.position = new Vector3(inicial.position.x, inicial.position.y, inicial.position.z);
        esfera.AddComponent<Rigidbody>();
        GameObject a = esfera;
        a.GetComponent<Rigidbody>().isKinematic = true;
        esfera.AddComponent<esfera>();
    }


}
