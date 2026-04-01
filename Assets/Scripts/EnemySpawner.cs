using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform spawnHere;
    public GameObject Enemy;
    private int spawnQty;
    private bool spawend = false;
    private BoxCollider colliderBox;

    void Awake()
    {
        spawnQty = Random.Range(1 , 10);
        colliderBox = GetComponent<BoxCollider>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(!spawend && other.CompareTag("Player"))
        {
            spawend = true;
            colliderBox.enabled = false;
            Debug.Log(spawnQty + "Zombies Spawned");
            Spawn();
        }
    }
    void Spawn()
    {
        for (int i = 0; i < spawnQty; i++)
    {
        Vector3 randomOffset = new Vector3(
            Random.Range(-5f, 5f),
            0,
            Random.Range(-5f, 5f)
        );

        Vector3 spawnPos = spawnHere.position + randomOffset;

        Instantiate(Enemy, spawnPos, spawnHere.rotation);
    }

    }

}
