using UnityEngine;

public class Health : MonoBehaviour
{
    public float playerHealth = 100f;
    public float enemyHealth = 100f;
    private GameObject playerObj;

    void Awake()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");

    }

    public void HurtPlayer(int hurtAmount)
    {
        playerHealth -= hurtAmount;
        if (playerHealth <= 0)
        {
            playerObj.SetActive(false);
        }
    }
    public void HurtEnemy(int hurtAmount)
    {
        enemyHealth -= hurtAmount;
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
