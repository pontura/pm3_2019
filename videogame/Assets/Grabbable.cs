using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    public void OnGrab()
    {
        Events.OnGrab(gameObject);
        Destroy(gameObject);
    }
}
