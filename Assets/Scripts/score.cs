using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // reference to the text component
    public Text scoreText;

    // Fixedupdate is called once per frame
    void FixedUpdate()
    {
        // Add 1 to the score
        scoreText.text = (transform.position.z - 5).ToString("0");
    }
}
