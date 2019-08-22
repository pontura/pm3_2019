using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float jumpForce = 500;
    public float speed = 10;
    public float rotationSpeed = 10;

    void Start()
    {
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Move(speed);
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(-speed/2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotate(rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotate(-rotationSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
    }
    void Move(float value)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * value);
    }
    void Rotate(float value)
    {
        transform.Rotate(Vector3.up * Time.deltaTime * value);
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.transform.gameObject;

        Grabbable grabbable = collision.transform.gameObject.GetComponent<Grabbable>();
        if (grabbable != null)
            grabbable.OnGrab();
       
    }
}
