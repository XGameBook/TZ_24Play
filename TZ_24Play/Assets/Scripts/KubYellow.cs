using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KubYellow : MonoBehaviour
{
    public GameObject kubYellow;
    public GameObject Player;
    public Transform kubYellowParent;
    public float positionKub=0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "yellow")
        {
            
            GameObject Yellows;
            
            Vector3 positionPlayer = new Vector3(Player.transform.position.x, Player.transform.position.y + 0.5f, Player.transform.position.z);
            Player.transform.position = positionPlayer;

             Vector3 positionKub1 = new Vector3(Player.transform.position.x, positionKub, Player.transform.position.z);
            
           Yellows = Instantiate(kubYellow, positionKub1, Quaternion.identity) as GameObject;
           Yellows.transform.SetParent(kubYellowParent);
            Destroy(other.gameObject);
            // positionKub -= 0.5f;
        }
    }
}
