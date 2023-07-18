using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class clashes : MonoBehaviour
{
    public GameObject Player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pregrads")
        {
            transform.SetParent(null);
        }
    }
}