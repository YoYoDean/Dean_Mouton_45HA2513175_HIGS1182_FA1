using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int collectable;
    public static GameManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // prevent duplicates
        }
        collectable = 0;
    }

}
