using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Data : MonoBehaviour
{

    const string PREFAB_PATH = "Data";    
    static Data mInstance = null;

	public static Data Instance
	{
		get
		{
			return mInstance;
		}
	}
    void Awake()
    {
        if (!mInstance)
            mInstance = this;
        DontDestroyOnLoad(this.gameObject);
    }

}
