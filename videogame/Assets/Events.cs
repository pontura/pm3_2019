using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Events {
   
    public static System.Action<GameObject> OnGrab = delegate { };
    public static System.Action OnDoorActive = delegate { };
}
