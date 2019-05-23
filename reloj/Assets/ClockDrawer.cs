using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockDrawer : MonoBehaviour
{
	public Item item;
    public Item itemEspecial;

    public float cant;
	public List<Item> allItems;
	public Clock clock;

    void Start()
    {
        Draw();
   	}
	void Draw()
	{
        int id = 0;
		for(int i=0; i<=cant; i++)
		{
            Item _item;
           
            if (id %3 == 0)
            {
                _item = Instantiate(itemEspecial);
            }
            else
            {
                _item = Instantiate(item);               
            }
            id++;
            _item.transform.SetParent(transform);
            _item.transform.localEulerAngles = new Vector3(0, 0, i * (360 / cant));
            _item.transform.localPosition = Vector3.zero;
            allItems.Add(_item);

        }
		
	}
	//void Update()
	//{
	//	for(int a = 0; a<allItems.Count; a++)
	//	{
	//		Item item = allItems[a];
	//		if(a<=clock.seg)
	//		{
	//			item.Init();
	//		} else
	//		{
	//			item.SetInactive();
	//		}
	//	}
	//}

}
