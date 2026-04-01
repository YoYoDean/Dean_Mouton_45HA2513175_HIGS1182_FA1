using UnityEngine;

public class Collectable : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Chicken Collected!");
            GameManager.instance.collectable += 1 ;
            UiManager.instance.UpdateScore();
            Destroy(gameObject);
        }
    }

}
