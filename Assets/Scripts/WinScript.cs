using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.instance.collectable == GameManager.instance.chickSpawend)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
