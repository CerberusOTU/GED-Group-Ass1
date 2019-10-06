using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginReader : MonoBehaviour
{
   const string DLL_NAME = "SimplePlugin";
   [DllImport(DLL_NAME)]
   static extern int ObjectsArrayLoad();
   [DllImport(DLL_NAME)]
   static extern void MarshallArraySave([In, Out] Vector3[] vecArray, int vecSize);
   [DllImport(DLL_NAME)]
   static extern System.IntPtr getPosition();

   float[] position;
    float px,py,pz;
    public GameObject canvas;
    public GameObject player;
    public Camera cam;
    public GameObject dragAndDrop;
    public List<Vector3> objectsPos = new List<Vector3>();
    public List<GameObject> objs = new List<GameObject>();

void Start()
{
   player.SetActive(false);
   dragAndDrop.SetActive(true);
}

 void Update()
 {
   if (Input.GetKeyDown(KeyCode.DownArrow))
   {
      objectsPos.Clear();
      //Transform obj = GetComponent<Transform>();
      for (int i=0;i<objs.Count;i++)
      {
         objectsPos.Add(new Vector3(objs[i].transform.localPosition.x,objs[i].transform.localPosition.y,objs[i].transform.localPosition.z));
         //Debug.Log(objectsPos[i]);
         //Debug.Log(objectsPos.Count);
      }
      //objects.Add(new Vector4(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z,1));
      MarshallArraySave(objectsPos.ToArray(), objectsPos.Count);
   }

   if (Input.GetKeyDown(KeyCode.UpArrow))
   {
   Debug.Log("Camera Switch");
   cam.GetComponent<Camera>().orthographic = false;
   GameObject.Find("Main Camera").transform.position = new Vector3(15.89f, 8.62f, -21.69f);
   GameObject.Find("Main Camera").transform.rotation = Quaternion.Euler(45,0,0);

   dragAndDrop.SetActive(false);
   player.SetActive(true);
   canvas.SetActive(false);

      int size = ObjectsArrayLoad();
      Debug.Log(size);
      Marshal.Copy(getPosition(), position , 0, size);

      for (int i = 0; i<(size); i+=3)
      {
         objs[i].transform.localPosition = new Vector3(position[i], position[i+1], position[i+2]);
      }
   }
 }
}