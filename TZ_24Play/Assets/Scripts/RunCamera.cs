using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RunCamera : MonoBehaviour
{
    public bool i;
    void Update()
    {
        if (Input.touchCount > 0)
        {
           i = true;
        }
        if (i==true)
        {
            Vector3 Run = new Vector3(0, 0, 4) * 4 * Time.deltaTime;
            transform.position += Run;
        }
        }
    }
