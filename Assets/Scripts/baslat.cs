using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class baslat : MonoBehaviour
{


    public void appExit()
    {
        Application.Quit();
    }

    public void StartGameOnClick()
    {
        SceneManager.LoadScene(1);
    }
}
