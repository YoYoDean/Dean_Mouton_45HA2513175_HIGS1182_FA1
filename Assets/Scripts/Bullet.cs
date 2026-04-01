using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 3f;

    void OnEnable()
    {
        Invoke(nameof(Disable), lifeTime);
    }

    void OnDisable()
    {
        CancelInvoke();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit: " + other.name);
        if (other.CompareTag("Enemy"))
    {
        // Get the Health comp on the enemy that was hit
        Health enemyHealth = other.GetComponent<Health>();
        if (enemyHealth != null)
        {
            enemyHealth.HurtEnemy(50);
        }
    }

        Disable(); // return to pool
    }

    void Disable()
    {
        gameObject.SetActive(false);
    }
}