using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsManager : MonoBehaviour
{
    public Door door;
    public Door door1;
    public Door door2;
    public Door door3;
    
    public void Init(bool value1, bool value2, bool value3, bool value4)
    {
        door.SetState(value1);
        door1.SetState(value2);
        door2.SetState(value3);
        door3.SetState(value4);
    }
}
