using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLib1: MonoBehaviour
{
    public void GoToLib1()
    {
        SceneManager.LoadScene("lib1");
    }
}
