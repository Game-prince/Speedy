using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacles")
        {
            SceneManager.LoadScene("gameOver");
        }
    }
}
