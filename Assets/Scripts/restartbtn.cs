using UnityEngine;
using UnityEngine.SceneManagement;

public class restartbtn : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }
}
