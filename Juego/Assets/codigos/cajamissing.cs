using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajamissing : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private Vector3 spawn;
    private float limiteDerecho = 40f;
    private float limiteIzquierdo = -40f;
    public GameObject deathParticles;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < limiteIzquierdo)
        {
            Instantiate(deathParticles, transform.position, Quaternion.Euler(270, 0, 0));
            //print("I hit enemy");
            transform.position = spawn;
        }
        if (transform.position.x > limiteDerecho)
        {
            Instantiate(deathParticles, transform.position, Quaternion.Euler(270, 0, 0));
            //print("I hit enemy");
            transform.position = spawn;
        }
    }
}
