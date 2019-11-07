using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ServerLoader : MonoBehaviour
{
    public DataLoaded dataLoaded;
    [Serializable]
    public class DataLoaded
    {
        public List<TutorialData> content;
    }
    private void Start()
    {
        StartCoroutine(LoadData());
    }
    IEnumerator LoadData()
    { 
        string url = "http://niitek.com.ar/api/tutorial.php";
        WWW www = new WWW(url);

        yield return www;
        if (www.error == null)
        {
            Processjson(www.text);
        }
        else
        {
            Debug.Log("ERROR: " + www.error);
        }
    }
    void Processjson(string data)
    {
        print(data);
        string d = "{\"content\":" + data + "}";
        print(d);
        dataLoaded = JsonUtility.FromJson<DataLoaded>(d);

    }
}
