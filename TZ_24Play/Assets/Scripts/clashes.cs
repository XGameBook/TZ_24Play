using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class clashes : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void clashe()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pregrads")
        {

            //transform.position = new Vector3(0, 0, 0);
            transform.SetParent(null);

        }

    }
    /*
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Pregrads")
        {
            Player = GameObject.Find("Player");
            Vector3 positoin = new Vector3(0, 0, 0.5f);
            Player.transform.position -= positoin;
        }

    }
    */

}