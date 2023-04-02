using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_grilla : MonoBehaviour
{
   
    private Vector3 targetPosition;
    private float yImput, xImput;
    private float moveTime=0.15f;
    private bool isMoving;
    private Animator anim;
   
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        xImput = Input.GetAxisRaw("Horizontal");
        yImput = Input.GetAxisRaw("Vertical");
        if((xImput!=0 || yImput!=0)&& !isMoving && Input.anyKeyDown)
        {
            calculatetargetposition();
            if (canmovetoTargetposition())
            {
                StartCoroutine(move());
            }
            
        }
        //para animar el personaje
        anim.SetFloat("VelX", xImput);
        anim.SetFloat("VelY", yImput);
    }
    IEnumerator move()
    {
        isMoving = true;
        float timeElapsed= 0f;
        Vector3 startPosition=transform.position;
        while (timeElapsed < moveTime)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, timeElapsed / moveTime);
            timeElapsed += Time.deltaTime;
            yield return null;        
        }
        transform.position = targetPosition;
        isMoving = false;
    }
    private void calculatetargetposition()
    {
        if (xImput == 1)
        {
            targetPosition = transform.position + Vector3.right;
        }
        if (xImput == -1)
        {
            targetPosition = transform.position + Vector3.left;
        }
        if (yImput == 1)
        {
            targetPosition = transform.position + new Vector3(0,0,yImput);
        }
        if (yImput == -1)
        {
            targetPosition = transform.position + new Vector3(0, 0, yImput);
        }
    }
    private bool canmovetoTargetposition()
    {
        Collider[] colliders = Physics.OverlapSphere(targetPosition, 0.10f);
        return colliders.Length == 0;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(targetPosition, 0.16f);
    }
   
}
