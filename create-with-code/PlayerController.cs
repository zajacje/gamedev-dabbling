using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get player input
        this.verticalInput = Input.GetAxis("Vertical");
        this.horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle
        this.transform.Translate(this.verticalInput * this.speed * Time.deltaTime * Vector3.forward);
        this.transform.Rotate(Vector3.up, this.horizontalInput * this.turnSpeed * Time.deltaTime);
        // deltaTime = car moves forward 1 meter per second

    }
}
