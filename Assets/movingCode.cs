using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movingCode : MonoBehaviour
{
    public void GoToRoad()
    {
        SceneManager.LoadScene("road");
    }

    public void GoToLib1()
    {
        SceneManager.LoadScene("lib1");
    }

    public void GoTolib1_zoom()
    {
        SceneManager.LoadScene("lib1_zoom");
    }

    public void GoToLib2()
    {
        SceneManager.LoadScene("lib2");
    }

    public void GoTolib2_zoom()
    {
        SceneManager.LoadScene("lib2_zoom");
    }
}