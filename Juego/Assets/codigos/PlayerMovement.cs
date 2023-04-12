using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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

    // Update is called once per frame
    void FixedUpdate()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(input * velocidad);
        }
        //print(input);
        if (transform.position.y < -2)
        {
            die();
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Police")
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

