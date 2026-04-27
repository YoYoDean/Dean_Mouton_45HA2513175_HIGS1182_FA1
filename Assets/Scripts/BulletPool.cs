using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public int poolSize = 20;

    private List<Rigidbody> pool = new List<Rigidbody>();

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            Rigidbody bullet = Instantiate(bulletPrefab, transform);
            bullet.gameObject.SetActive(false);
            pool.Add(bullet);
        }
    }

    public Rigidbody GetBullet()
    {
        //Debug.Log("RunGETBULLET");
        foreach (Rigidbody bullet in pool)
        {
           // Debug.Log("foreach");
            if (!bullet.gameObject.activeInHierarchy)
            {
               // Debug.Log("Bullet");
                return bullet;
            }
        }
       // Debug.Log("NewBullet");
        Rigidbody newBullet = Instantiate(bulletPrefab, transform);
        pool.Add(newBullet);
        
        return newBullet;
    }
}
