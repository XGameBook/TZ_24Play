using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnTrack : MonoBehaviour
{
    public GameObject Kub;
    public GameObject Kubyellow;
    public GameObject Track;
    public Transform parentalTrack;
    public Transform parentalPregradKub;
    public Transform parentalKubyellow;
    private float DistanceRrack = 30;
    private float PositoinTracspawn = 0f;
    public bool StartingGenerahenTrak = true;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (StartingGenerahenTrak == true)
        {
            spawnTrack();
            spawnPregrads();
            SpawnPersKubs();
        }

    }
    public void spawnTrack()
    {
        //Спавн трека на сценну
        GameObject Trak2;
        Vector3 Trak = new Vector3(0, 0, PositoinTracspawn);
        Trak2 = Instantiate(Track, Trak, Quaternion.identity) as GameObject;
        Trak2.transform.SetParent(parentalTrack);
        PositoinTracspawn += DistanceRrack;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Track")
        {
            StartingGenerahenTrak = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Track")
        {
            StartingGenerahenTrak = true;
        }
    }


    void spawnPregrads()
    {
        GameObject Pregrads;
        int numbeCubes = 0;
        for (int i = -2; i < 3; i++)
        {
            numbeCubes = Random.Range(1, 5);
            for (int j = 0; j < numbeCubes; j++)
            {
                Vector3 kub = new Vector3(i, j, PositoinTracspawn);
                Pregrads = Instantiate(Kub, kub, Quaternion.identity)as GameObject;
                Pregrads.transform.SetParent(parentalPregradKub);
            }
        }
    }

    void SpawnPersKubs()
    {
        GameObject KubYellows;
        int distance = 0;
        for (int i = 0; i < Random.Range(4,5); i++)
        {
            distance += 2;
            Vector3 kub = new Vector3(Random.Range(-2, 2), 0.5f, PositoinTracspawn + 10 + distance);
            KubYellows=Instantiate(Kubyellow, kub, Quaternion.identity)as GameObject;
            KubYellows.transform.SetParent(parentalKubyellow);
        }
    }
}
