using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject Box;
    public GameObject Spike;

    public GameObject GetNewInstanceBox()
    {
        Debug.Log("Box Spawned");
        return Instantiate(Box);
    }

    public GameObject GetNewInstanceSpike()
    {
        return Instantiate(Spike);
    }
}
