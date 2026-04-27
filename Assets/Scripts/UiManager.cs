using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    
    public TextMeshProUGUI coll;
    public TextMeshProUGUI enemyKill;
    public TextMeshProUGUI health;
    public TextMeshProUGUI currWave;
    public TextMeshProUGUI money;
    public GameObject pressEKey;
    public static UiManager instance;
    public TextMeshProUGUI highMoney;
    public TextMeshProUGUI highZombie;
    public TextMeshProUGUI highColl;
    public TextMeshProUGUI highWaves;
    public wavespawn wavespawn;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // prevent duplicates
        }
        
        if(SceneManager.GetActiveScene().name == "EndlessMode")
         {wavespawn = GameObject.FindGameObjectWithTag("wavespawn").GetComponent<wavespawn>();
            UpdateMoney();         
         }
        //Debug.Log("Check");
        if(SceneManager.GetActiveScene().name == "Start")
        {
        highMoney.text = "Money: " + PlayerPrefs.GetInt("Money");
        highColl.text = "Chickens Collected: " + PlayerPrefs.GetInt("collectable");
        highZombie.text = "Zonmbies Killed: " + PlayerPrefs.GetInt("EnemiesKilled");
        highWaves.text = "Waves Lasted: " + PlayerPrefs.GetInt("Waves");
        }

    }

    public void UpdateScore()
    {
        coll.text = "Chickens Collected: " + GameManager.instance.collectable;
        enemyKill.text = "Enemies Killed: " + GameManager.instance.enemyKilled;
        
    }
    public void UpdateMoney()
    {
        money.text = "Money: " + GameManager.instance.money;
        PlayerPrefs.SetInt("Money", GameManager.instance.money);
    }

    public void UpdateHealth()
    {
        health.text = "Health: " + Health.instance.playerHealth;
    }
    public void CurrentWave(int value)
    {
        currWave.text = "Wave: " + value;
        if(value > PlayerPrefs.GetInt("Waves"))
        {
         PlayerPrefs.SetInt("Waves", wavespawn.instance.currentWave);   
        }
        
    }


}
