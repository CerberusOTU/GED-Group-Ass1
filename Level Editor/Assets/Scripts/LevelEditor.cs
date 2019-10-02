using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditor : MonoBehaviour
{
    private Factory myFactory; 

    // Start is called before the first frame update
    void Start()
    {
        myFactory = GetComponent<Factory>();
    }

    public void AddBox()
    {
        myFactory.GetNewInstanceBox();
    }

        public void AddSpike()
    {
        myFactory.GetNewInstanceSpike();
    }

    public void AddVWall()
    {
        myFactory.GetNewInstanceVWall();
    }

    public void AddHWall()
    {
        myFactory.GetNewInstanceHWall();
    }
}
