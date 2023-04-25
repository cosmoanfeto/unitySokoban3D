using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class police : MonoBehaviour
{
    public float velocidad = 5f;
    private float limiteDerecho = 40f;
    private float limiteIzquierdo = -40f;


    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);

        //// Si el objeto se sale de la c�mara por la derecha, lo coloca en la izquierda
        //if (transform.position.x > limiteDerecho)
        //{
        //    Vector3 nuevaPosicion = new Vector3(limiteIzquierdo, 1, 1);
        //    transform.position = nuevaPosicion;
        //}

        // Si el objeto se sale de la c�mara por la izquierda, lo coloca en la derecha
        if (transform.position.x < limiteIzquierdo)
        {
            Vector3 nuevaPosicion = new Vector3(limiteDerecho, 0, -3);
            transform.position = nuevaPosicion;
        }
    }
}