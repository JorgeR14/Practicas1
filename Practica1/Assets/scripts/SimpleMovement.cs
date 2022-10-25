using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float movingspeed;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * movingspeed;
    }
}