using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : PlayerTrigger
{
    public float forcemagnitude = 15;

    public override void OnPlayerEnter(GameObject playerobject)
    {
        Rigidbody rb = playerobject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * forcemagnitude, ForceMode.Impulse);
    }
}