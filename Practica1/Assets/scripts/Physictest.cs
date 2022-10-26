using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physictest : MonoBehaviour
{
    public Rigidbody myrigidbody;

    public Vector3 rigidBodyVelocity;

    public float forceMagnitude;
    public Vector3 forceDirection;

    // Start is called before the first frame update
    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
        //myrigidbody.AddTorque(forceDirection * forceMagnitude, ForceMode.Impulse);
    }

    // Update is called once per frame
    private void Update()
    {
        rigidBodyVelocity = myrigidbody.velocity;
    }

    private void FixedUpdate()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colision detectada");
        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("estoy colisionando");
    }
}