using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Restart : MonoBehaviour
{
    public void OnMouseUp()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
