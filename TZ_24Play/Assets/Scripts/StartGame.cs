using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class StartGame : MonoBehaviour
{
    private float PositionY = 4;
    public GameObject TapTopPlay;
    public bool StartGame1 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            TapTopPlay.SetActive(false);

            StartGame1 = true;
        }
        if (StartGame1 == true)
        {
           // startGame();
        }
    }

    /*
    public void startGame()
    {
        TapTopPlay.SetActive(false);
        Vector3 Run = new Vector3(0, 0, PositionY) * 4 * Time.deltaTime;
        transform.position += Run;
    }
    */
}
