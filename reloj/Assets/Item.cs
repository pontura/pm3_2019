using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	public Animation anim;
	bool isActive;

    	public void Init()
    	{
		if(isActive == false)
		{
			isActive = true;
       			anim.Play("latir");
		}
    	}
	public void SetInactive()
    	{
		isActive = false;
        	anim.Stop();
    	}
}
