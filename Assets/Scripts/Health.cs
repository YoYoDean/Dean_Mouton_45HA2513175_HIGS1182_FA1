using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float playerHealth = 100f;
    public float enemyHealth = 100f;
    private GameObject playerObj;
    public static Health instance;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    public void HurtPlayer(int hurtAmount)
    {
        playerHealth -= hurtAmount;
        UiManager.instance.UpdateHealth();
        if (playerHealth <= 0)
        {
            Debug.Log("Player Killed!");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("GameOver");
        }
    }
    public void HurtEnemy(int hurtAmount)
    {
        enemyHealth -= hurtAmount;
        if (enemyHealth <= 0)
        {
            Debug.Log("Enemy Killed!");
            Destroy(gameObject);
        }
    }

}
