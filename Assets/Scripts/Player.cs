using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rig;
    public float Velocidade;
    public float ForcaPulo;
    
    void Start()
    {
        Rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Velocidade * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1,0,0) * Velocidade * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Velocidade * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-1) * Velocidade * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //transform.Translate(new Vector3(0, 1, 0) * ForcaPulo * Time.deltaTime);
            Rig.velocity = new Vector3(0, 1, 0) * ForcaPulo * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Inimigo"))
        {
            Destroy(gameObject);
        }
    }
}
