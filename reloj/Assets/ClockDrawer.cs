using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockDrawer : MonoBehaviour
{
	public GameObject prefab;

    	void Start()
    	{
        	Draw();
   	}
	void Draw()
	{		
		for(int i=0; i<=60; i++)
		{
			GameObject createdPrefab = Instantiate(prefab);			
			createdPrefab.transform.SetParent(transform);
			createdPrefab.transform.localEulerAngles = new Vector3(0,0,i*6); 
			createdPrefab.transform.localPosition = Vector3.zero; 
		}
		
	}

}
