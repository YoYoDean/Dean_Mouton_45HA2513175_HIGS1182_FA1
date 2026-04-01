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
        for(int i = 0; spawnQty > i ; i++)
        {
        Instantiate(Enemy, spawnHere.position, spawnHere.rotation);
        }
    }



}
