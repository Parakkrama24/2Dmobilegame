using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherbackgroundObjects : MonoBehaviour
{
    public Rigidbody _body;
    void Start()
    {
        
        _body.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _body.velocity = new Vector3(0, -2, 0);
    }

    private void OnTriggerEnter(Collider Target)
    {
       
    }
}
