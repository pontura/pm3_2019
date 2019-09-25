using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool isOn;

    public void SetState(bool isOn)
    {
        this.isOn = isOn;
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name + " is on: " + isOn);
    }
}
