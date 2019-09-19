using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float jumpForce = 500;
    public float speed = 10;
    public float rotationSpeed = 10;
    public CharacterView characterView;

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Move(Vector3.forward, speed);
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(Vector3.forward, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move(Vector3.right, speed);
            characterView.Flip(1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move(Vector3.right, -speed);
            characterView.Flip(-1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Move(Vector3 v, float value)
    {
        transform.Translate(v * Time.deltaTime * value);
    }
    void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
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
