using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarafollwer : MonoBehaviour
{
    public Transform traget;
    public float smoothspeed =10f;

    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desiredpoint = traget.position + offset;
        Vector3 smoothedpotion = Vector3.Lerp(transform.position,desiredpoint,smoothspeed);

        transform.position = smoothedpotion;

    }
}
