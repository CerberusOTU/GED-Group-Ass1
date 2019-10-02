using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginReader : MonoBehaviour
{
     const string DLL_NAME = "SIMPLEPLUGIN";
    [DllImport(DLL_NAME)]
    private static extern int TestFunction();
    [DllImport(DLL_NAME)]
    private static extern int SaveFunction(float x, float y, float z, int count);
    [DllImport(DLL_NAME)]
    private static extern Vector3 LoadFunction();


    private Factory myScript;
    public GameObject Box;
    private Rigidbody rb;

    float PosX, PosY, PosZ;
    
    void Start()
    {
        rb = Box.GetComponent<Rigidbody>();
    }

     public void SaveToDLL()
     {
          
            PosX = rb.GetComponent<Rigidbody>().position.x;
            PosY = rb.GetComponent<Rigidbody>().position.y;
            PosZ = rb.GetComponent<Rigidbody>().position.z;

            Debug.Log("Save to file test");
            SaveFunction(PosX, PosY, PosZ, myScript.ObjectCount);
            Debug.Log(SaveFunction(PosX, PosY, PosZ, myScript.ObjectCount));
     }

     public void LoadFromDLL()
     {
          Vector3 loc = LoadFunction();

          Debug.Log(loc.x);
          Debug.Log(loc.y);
          Debug.Log(loc.z);

          Box.GetComponent<Rigidbody>().position = new Vector3(loc.x, loc.y, loc.z);

          rb.GetComponent<Rigidbody>().position = new Vector3(PosX, PosY, PosZ);

          Debug.Log(LoadFunction());
          Debug.Log("Loaded");
     }
}