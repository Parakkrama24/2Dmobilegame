using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectInstansiate : MonoBehaviour
{

    public GameObject _object;
    void Start()
    {
        InvokeRepeating("objectSpowner",1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //in
    }
    private void objectSpowner()
    {
        Instantiate(_object, new Vector3(Random.Range(0.68f, -5.29f), 7f, 0f), transform.rotation);
    }
}//class
