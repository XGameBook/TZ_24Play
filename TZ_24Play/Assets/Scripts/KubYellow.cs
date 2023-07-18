using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KubYellow : MonoBehaviour
{
    public GameObject kubYellow;
    public GameObject Player;
    public GameObject checkerTextobject;
    public Animator PlayerJamp;
    public Transform kubYellowParent;
    public Transform ParentText;
    public GameObject jampEfect;
    public float positionKubY = 0f;
    GameObject Yellows;
    public GameObject effectObject;

    private ParticleSystem particleSystem;
    private void Start()
    {
        particleSystem = effectObject.GetComponent<ParticleSystem>();
        particleSystem.Pause();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yellow")
        {
            Destroy(other.gameObject);
            Vector3 positionKub1 = new Vector3(Player.transform.position.x, positionKubY, Player.transform.position.z);
            Yellows = Instantiate(kubYellow, positionKub1, Quaternion.identity) as GameObject;
            Yellows.transform.SetParent(kubYellowParent);
            PlayerJamp.SetTrigger("Jump");
            particleSystem.Play();
            checker();
        }
    }


    private void checker()
    {
        GameObject ParentText1;
        Vector3 positionKub1 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        ParentText1 = Instantiate(checkerTextobject, positionKub1, Quaternion.identity) as GameObject;

        Vector3 positionKub2 = new Vector3(transform.position.x, transform.position.y+3, transform.position.z);
        ParentText1.transform.position = positionKub2;  
    }

}
