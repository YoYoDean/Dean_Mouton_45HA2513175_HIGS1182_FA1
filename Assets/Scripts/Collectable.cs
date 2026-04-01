using UnityEngine;

public class Collectable : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.collectable += 1 ;
            Destroy(gameObject);
        }
    }

}
