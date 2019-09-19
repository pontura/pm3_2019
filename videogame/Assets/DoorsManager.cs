using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsManager : MonoBehaviour
{
    public GameObject door;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    
    public void Init(bool value1, bool value2, bool value3, bool value4)
    {
        door.SetActive(value1);
        door1.SetActive(value2);
        door2.SetActive(value3);
        door3.SetActive(value4);
    }
}
