using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class CrateSpawn : MonoBehaviour
{

    public GameObject obj;
    public Vector2 areaXSize = new Vector2(-20,20);
    public Vector2 areaZSize = new Vector2(-20,20);
    public int numberOfObjects = 10;
    


    void Start()
    { 
        SpawnCrate();

    }
    void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            SpawnCrate();
        }
    }

    public void SpawnCrate()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float xCor = Random.Range(areaXSize.x, areaXSize.y);
            float zCor = Random.Range(areaZSize.x, areaZSize.y);

            //Debug.Log(xCor + "" + zCor + "" + objToSpawn);

            Instantiate(obj, new Vector3(xCor, 0.5f, zCor), quaternion.identity);
        }
    }
}
