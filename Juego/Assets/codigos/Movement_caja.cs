using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_caja : MonoBehaviour
{
    public float velocidad;
    private Vector3 input;
    private float maxSpeed = 5f;
    private Rigidbody rb;
    private Vector3 spawn;
    public GameObject deathParticles;
    public GameObject Ganaste;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawn = transform.position;
        
    }
    private void FixedUpdate()
    {
        if (transform.position.y < -2)
        {
            die();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }
    }
    // Update is called once per frame
    void Respawn()
    {
        transform.position = spawn;
        // También puedes restablecer cualquier otra variable que necesites aquí
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy" && velocidad==0 )
        {
            die();
        }
        if (other.transform.tag == "Goal")
        {
            Controlador.completeLevel();
            //Instantiate(Ganaste);
            velocidad = 0;
        }
        if (other.transform.tag == "police_object" && velocidad == 0)
        {
            die();
        }
    }
   
    void die()
    {
        Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));
        //print("I hit enemy");
        transform.position = spawn;
    }
}

