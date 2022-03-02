using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}