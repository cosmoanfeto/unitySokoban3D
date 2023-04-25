using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad;
    private Vector3 input;
    private float maxSpeed = 3f;
    private Rigidbody rb;
    private Vector3 spawn;
    public GameObject deathParticles;
    public GameObject Ganaste;

    public int muertes = 0;
    public Text muertesTexto;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawn = transform.position;

        // Asigna el objeto de texto en la UI a la variable muertesTexto
        muertesTexto = GameObject.Find("TextoMuertes").GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Obtener el vector de entrada del teclado
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        // Si el vector de entrada no es cero, rotar el objeto para que mire hacia la dirección de entrada
        if (input != Vector3.zero)
        {
            // Crear un vector que apunte en la dirección del input
            Vector3 lookDirection = new Vector3(-input.z, 0, input.x);

            // Rotar el objeto para que mire en la dirección del lookDirection
            transform.LookAt(transform.position + lookDirection);
        }

        // Mover el objeto con la fuerza definida en la variable velocidad
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(input * velocidad);
        }

        // Verificar si el objeto se encuentra por debajo del límite de altura y aplicar la función die()
        if (transform.position.y < -2)
        {
            die();
        }
       

       
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            die();
        }
        
    }
   
    void die()
    {
        Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));
        //print("I hit enemy");
       
        transform.position = spawn;
        muertes++; // Incrementa el número de muertes
                   // Actualiza el texto en la UI
        muertesTexto.text = "Muertes: " + muertes.ToString();

        if (muertes >= 3)
        {
            // Si el jugador ha muerto tres veces, haz algo ...
        }
    }
}

