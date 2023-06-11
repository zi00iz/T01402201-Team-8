using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private int isButtonPressed;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetScore(int newScore)
    {
        isButtonPressed = newScore;
    }

    public int GetScore()
    {
        return isButtonPressed;
    }
}
