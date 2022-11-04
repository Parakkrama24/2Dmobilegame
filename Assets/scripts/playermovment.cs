using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public Rigidbody _playerody;
    public int speed = 10;
    public int jumpForce = 10;


    private float horizontalinput;
   private float verticalInput;
    private Vector3 horizontalMovemnt;
    private Vector3 VerticaleMovement;
    private bool isground =true;
    

    int inputvaluve;
    void start()
    {

        _playerody.GetComponent<Rigidbody>();
    }
    void Update()
    {
    movement();
    }
    void OnTriggerEnter(Collider Target)
    {
        if (Target.gameObject.CompareTag("ground")  )
        {
            isground = true;
            Debug.Log("check");
        }
        else if (Target.gameObject.CompareTag("cube"))
        {
            isground = true;
            Debug.Log("check2");
        }
        
        
        
        if (Target.gameObject.CompareTag("redGround"))
        {
            Destroy(this.gameObject);
        }
    }

    

    private void movement()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        horizontalMovemnt = new Vector3(horizontalinput, 0, 0);
        //VerticaleMovement = new Vector3(horizontalinput, 0, 0);
        //checkground();

        if (horizontalinput > 0)
        {
            _playerody.velocity = new Vector3(horizontalMovemnt.x * speed * Time.deltaTime, 0, 0);
            if (Input.GetKeyDown(KeyCode.Space) && isground == true)
            {
                _playerody.AddForce(100, 100, 0, ForceMode.Impulse);
                isground = false;
            }
        }
        else if (horizontalinput < 0 )
        {
            _playerody.velocity = new Vector3(horizontalMovemnt.x * speed * Time.deltaTime, 0, 0);
            if(Input.GetKeyDown(KeyCode.Space) && isground == true)
            {
                _playerody.AddForce(-100, 100, 0, ForceMode.Impulse);
                isground = false;
            }
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Space) && isground == true) 
        {
            _playerody.AddForce(0, 20, 0, ForceMode.Impulse);
            isground = false;
        }
    }
   
} 
