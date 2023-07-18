using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public GameObject TryAgain;
    public GameObject ButtonTruAgan;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pregrads")
        {
            ButtonTruAgan.SetActive(true);
            TryAgain.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
