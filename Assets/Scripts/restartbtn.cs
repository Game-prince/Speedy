using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartbtn : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
