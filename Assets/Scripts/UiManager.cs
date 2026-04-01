using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    
    public TextMeshProUGUI coll;
    public TextMeshProUGUI health;
    public static UiManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // prevent duplicates
        }
    }

    public void UpdateScore()
    {
        coll.text = "Chickens Collected " + GameManager.instance.collectable 
                    + "/" + GameManager.instance.chickSpawend;
    }

    public void UpdateHealth()
    {
        health.text = "Health: " + Health.instance.playerHealth;
    }


}
