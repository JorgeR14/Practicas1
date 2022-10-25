using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilLauncher : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject proyectilePrefab;

    public float timeToShoot = 1;
    private float timeSinceLastShoot = 0;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;
        if (timeSinceLastShoot >= timeToShoot)
        {
            Instantiate(proyectilePrefab, shootPoint.position, shootPoint.rotation);
            timeSinceLastShoot = 0;
        }
    }
}