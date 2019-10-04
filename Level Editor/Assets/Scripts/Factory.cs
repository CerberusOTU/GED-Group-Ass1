using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public PluginReader pluginDll;
    public GameObject Box;
    public GameObject Spike;
    public GameObject VerticalWall;
    public GameObject HorizontalWall;

    void Start() 
    {
        pluginDll = GetComponent<PluginReader>();
    }

    public int ObjectCount = 0;
    //List<GameObject> Objects = new List<GameObject>();

    public GameObject GetNewInstanceBox()
    {
        //Objects += [Box];
        //Objects.Add(Box);
        GameObject objTemp = Instantiate(Box);
        ObjectCount++;
        pluginDll.objs.Add(objTemp);
        return objTemp;
    }

    public GameObject GetNewInstanceSpike()
    {
        //Objects.Add(Spike);
        GameObject objTemp = Instantiate(Spike);
        ObjectCount++;
        pluginDll.objs.Add(objTemp);
        return Instantiate(objTemp);
    }

    public GameObject GetNewInstanceVWall()
    {
        //Objects.Add(VerticalWall); 
        GameObject objTemp = Instantiate(VerticalWall);
        ObjectCount++;
        pluginDll.objs.Add(objTemp);
        return Instantiate(objTemp);
    }
    
    public GameObject GetNewInstanceHWall()
    {
        //Objects.Add(HorizontalWall);
        GameObject objTemp = Instantiate(HorizontalWall);
        ObjectCount++;
        pluginDll.objs.Add(objTemp);
        return Instantiate(objTemp);
    }
}
