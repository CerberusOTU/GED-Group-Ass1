using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class PluginReader : MonoBehaviour
{
 const string DLL_NAME = "SimplePlugin";
 [DllImport(DLL_NAME)]
 private static extern int SimpleFunction();
[DllImport(DLL_NAME)]
 private static extern int SimpleSave(float x, float y, float z);
[DllImport(DLL_NAME)]
 private static extern Vector3 SimpleLoad();

 [DllImport(DLL_NAME)]
 static extern void MarshallArraySave([In, Out] Vector4[] vecArray, int vecSize);

 //GameObject box;
    float px,py,pz;
    public List<Vector4> objectsPos = new List<Vector4>();
    public List<GameObject> objs = new List<GameObject>();

 void start(){
 }

 void Update()
 {
 if (Input.GetKeyDown(KeyCode.C))
 {
    Debug.Log(SimpleFunction());
 }

 if (Input.GetKeyDown(KeyCode.DownArrow))
 {
      //px = box.transform.localPosition.x;
      //py = box.transform.localPosition.y;
      //pz = box.transform.localPosition.z;

      //SimpleSave(px,py,pz);s
 }

 if (Input.GetKeyDown(KeyCode.UpArrow))
 {
   //Vector3 position = SimpleLoad();
   //box.transform.localPosition = position;
 }

  ///Remove from update and place in execute function.!--
 if (Input.GetKeyDown(KeyCode.O))
 {
    objectsPos.Clear();
    //Transform obj = GetComponent<Transform>();
    for (int i=0;i<objs.Count;i++)
    {
        objectsPos.Add(new Vector4(objs[i].transform.localPosition.x,objs[i].transform.localPosition.y,objs[i].transform.localPosition.z,1));
        Debug.Log(objectsPos[i]);
        Debug.Log(objectsPos.Count);
    }
    //objects.Add(new Vector4(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z,1));
    MarshallArraySave(objectsPos.ToArray(), objectsPos.Count);
    Debug.Log(objectsPos.ToArray());
 }
 }
}