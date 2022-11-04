using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _MoveSpeed = 20;
    [SerializeField] float _JumpSpeed = 20;
    [SerializeField] float _JumpHight = 5;
    [SerializeField] float _RayCastHight = 0.8f;

    float _horizantal = 0;
    float _virticle = 0;
    bool _jump = false;
    bool _drop = false;
    float _startypos = 0;
    bool _ground = false;
    private void Update()
    {
        _horizantal = Input.GetAxis("Horizontal");
        _virticle = Input.GetAxis("Vertical");

        Ray _ray = new Ray(transform.position, Vector3.down);
        RaycastHit _hit = new RaycastHit();
        if (Physics.Raycast(_ray, out _hit, _RayCastHight))
        {
            if (_hit.collider.transform != transform)
            {
                _ground = true;
            }
        }
        else
        {
            _ground = false;
        }
    }

    private void FixedUpdate()
    {
        if (_virticle > 0 && _ground)
        {
            _startypos = transform.position.y;
            _jump = true;
            _drop = false;
        }

        if (_jump)
        {
            if (transform.position.y - _startypos < _JumpHight)
            {
                _rb.velocity = new Vector3(_rb.velocity.x, _JumpSpeed, _rb.velocity.z);
            }
            else
            {
                _jump = false;
                _drop = true;
            }

            if (_virticle == 0)
            {
                _jump = false;
                _drop = true;
            }
        }

        if (_drop)
        {
            if (_rb.velocity.y < 0 && _ground)
            {
                _rb.velocity = new Vector3(_rb.velocity.x, 0, _rb.velocity.z);
                _drop = false;
            }
        }

        _rb.velocity = new Vector3(_MoveSpeed * _horizantal, _rb.velocity.y, _rb.velocity.z);

    }
}