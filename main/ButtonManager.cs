using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonManager : MonoBehaviour
{

    public void ChangeVariable()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            gameManager.SetScore(1);
        }

    }

    public void LoadScene()
    {

        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            
            
            int isButtonPressed = gameManager.GetScore();

            if (isButtonPressed == 1)
            {
                Debug.Log("Current score: " + isButtonPressed);
                SceneManager.LoadScene("last");
            }
            else
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

        
    }
}
