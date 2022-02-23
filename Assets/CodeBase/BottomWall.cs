using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
