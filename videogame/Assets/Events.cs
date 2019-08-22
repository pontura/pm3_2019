using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Events {

    //la funcion recibe un valor que es todo el gameObject (en este caso)
    public static System.Action<GameObject> OnGrab = delegate { };	
    
}
