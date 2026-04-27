using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public Transform spawnHere;
    public GameObject coin;
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
            GameManager.instance.chickSpawend += spawnQty;
            UiManager.instance.UpdateScore();
            Debug.Log(spawnQty + "Chickens Spawned");
            Spawn();
        }
    }
    public void Spawn()
    {
        for (int i = 0; i < spawnQty; i++)
    {
        Vector3 randomOffset = new Vector3(
            Random.Range(-5f, 5f),
            0,
            Random.Range(-5f, 5f)
        );

        Vector3 spawnPos = spawnHere.position + randomOffset;

        Instantiate(coin, spawnPos, spawnHere.rotation);
    }
    }
    public void SpawnEnlessMode()
    {
        for (int i = 0; i < spawnQty; i++)
    {
        Instantiate(coin, spawnHere.position, spawnHere.rotation);
    }
    }



}

