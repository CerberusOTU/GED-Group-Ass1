using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Spawner;
    public string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            Debug.Log("WIN");
            SceneManager.LoadScene(sceneName);
           //rb.GetComponent<Rigidbody>().position = new Vector3(SpawnPoint.GetComponent<Rigidbody>().position.x, 
                                                                //SpawnPoint.GetComponent<Rigidbody>().position.y, 
                                                               // SpawnPoint.GetComponent<Rigidbody>().position.z);
        }    

        if (collision.gameObject.tag == "Death")
        {
            Debug.Log("Death");
           //rb.GetComponent<Rigidbody>().position = new Vector3(SpawnPoint.GetComponent<Rigidbody>().position.x, 
                                                                //SpawnPoint.GetComponent<Rigidbody>().position.y, 
                                                               // SpawnPoint.GetComponent<Rigidbody>().position.z);
        }    

    }

}
