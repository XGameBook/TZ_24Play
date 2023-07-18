using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class StartGame : MonoBehaviour
{
    public float speed = 4;
    public GameObject TapTopPlay;
    public bool StartGame1 = false;
   
    void Update()
    { 
            startGame(); 
    }

    public void startGame()
    {
        if (Input.touchCount > 0)
        {
            TapTopPlay.SetActive(false);

            StartGame1 = true;
        }
        if (StartGame1 == true)
        {
            Vector3 Run = new Vector3(0, 0, 4) * speed * Time.deltaTime;
            transform.position += Run;
        }
    }
    
}
