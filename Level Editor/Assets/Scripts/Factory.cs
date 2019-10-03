using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject Box;
    public GameObject Spike;
    public GameObject VerticalWall;
    public GameObject HorizontalWall;

    public int ObjectCount = 0;
    //List<GameObject> Objects = new List<GameObject>();
    public GameObject[] Objects;

    public GameObject GetNewInstanceBox()
    {
        //Objects += [Box];
        //Objects.Add(Box);
        ObjectCount++;
        return Instantiate(Box);
    }

    public GameObject GetNewInstanceSpike()
    {
        //Objects.Add(Spike);
        ObjectCount++;
        return Instantiate(Spike);
    }

    public GameObject GetNewInstanceVWall()
    {
        //Objects.Add(VerticalWall); 
        ObjectCount++;
        return Instantiate(VerticalWall);
    }
    
    public GameObject GetNewInstanceHWall()
    {
        //Objects.Add(HorizontalWall);
        ObjectCount++;
        return Instantiate(HorizontalWall);
    }
}
