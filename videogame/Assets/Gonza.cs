using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gonza : MonoBehaviour
{
    public GameObject gonzaCube;
    public List<GameObject> all;

    void Start()
    {
        for (int a = 0; a < 25; a++)
        {
            GameObject g = Instantiate(gonzaCube);
            id = 0;
            Positionate(g);
            all.Add(g);
        }
    }
    GameObject GetRandomTarget()
    {
        if (all.Count == 0)
            return null;
        return all[Random.Range(0, all.Count)];
    }
    GameObject randomObject2;
    int id = 0;
    void Positionate(GameObject go)
    {
        if (all.Count == 0)
            return;

        GameObject randomObject;

        if (id == 0 && randomObject2 != null)
            randomObject = randomObject2;
        else
            randomObject = GetRandomTarget();

        id++;
        randomObject2 = randomObject;

        

        Vector3 p;
        int r = (int)Random.Range(- 1, 2);
        if (Random.Range(0,10)<5)
            p = new Vector3(r, 0, 0);
        else
            p = new Vector3(0, 0, r);
        go.transform.position = randomObject.transform.position + p;
        print(r);
        if(IsACubeHere(go))
        {
            Positionate(go);
        }
    }
    bool IsACubeHere(GameObject go)
    {
        foreach(GameObject g in all)
        {
            if (g != go && g.transform.position == go.transform.position)
                return true;
        }
        return false;
    }
}
