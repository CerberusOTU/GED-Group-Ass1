using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject Box;
    public GameObject Spike;
    public GameObject VerticalWall;
    public GameObject HorizontalWall;

    public GameObject GetNewInstanceBox()
    {
        return Instantiate(Box);
    }

    public GameObject GetNewInstanceSpike()
    {
        return Instantiate(Spike);
    }

    public GameObject GetNewInstanceVWall()
    {
        return Instantiate(VerticalWall);
    }
    
    public GameObject GetNewInstanceHWall()
    {
        return Instantiate(HorizontalWall);
    }
}
