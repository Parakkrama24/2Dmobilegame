using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    private CharacterController _cController;
    void Start()
    {
        _cController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _cController.Move
    }
}
