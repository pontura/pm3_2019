using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockDrawer : MonoBehaviour
{
	public Item item;
	public float cant;
	public List<Item> allItems;
	public Clock clock;

    	void Start()
    	{
        	Draw();
   	}
	void Draw()
	{		
		for(int i=0; i<=cant; i++)
		{
			Item createdPrefab = Instantiate(item);			
			createdPrefab.transform.SetParent(transform);
			createdPrefab.transform.localEulerAngles = new Vector3(0,0,i*(360/cant)); 
			createdPrefab.transform.localPosition = Vector3.zero; 
			allItems.Add(createdPrefab);
		}
		
	}
	void Update()
	{
		for(int a = 0; a<allItems.Count; a++)
		{
			Item item = allItems[a];
			if(a<=clock.seg)
			{
				item.Init();
			} else
			{
				item.SetInactive();
			}
		}

		
	}

}
