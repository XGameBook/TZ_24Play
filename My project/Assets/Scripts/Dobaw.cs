using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Dobaw : MonoBehaviour
{
    public GameObject Dobavit;
    public Transform Osnovapleer;
    public int s=0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "1")
        {
            s++;
            Destroy(other.gameObject);
            Vector3 Pisition= new Vector3(transform.position.x, transform.position.y-1, transform.position.z);
            GameObject Objec =Instantiate(Dobavit, Pisition, Quaternion.identity) as GameObject;
            Objec.transform.SetParent(Osnovapleer);
          
        }
    }
}
