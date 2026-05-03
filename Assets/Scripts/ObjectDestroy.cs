using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Debug.Log("Destroy Crate!");
            Destroy(gameObject);
        }
    }

}
