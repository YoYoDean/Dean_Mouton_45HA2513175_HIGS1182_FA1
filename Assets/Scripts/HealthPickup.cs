using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.InputSystem;

public class HealthPickup : MonoBehaviour
{
    private bool isInside;
    public UiManager ui;
    void Awake()
    {
         ui = GameObject.FindGameObjectWithTag("UiManager").GetComponent<UiManager>();
    }
    void Update()
    {
        if (isInside && Keyboard.current.eKey.wasPressedThisFrame &&  GameManager.instance.money >= 20)
        {
            GameManager.instance.money -= 20;
            Health.instance.HealPlayer();
            ui.UpdateMoney();

        }
    }
    void OnTriggerEnter(Collider other)
    {
        ui.pressEKey.SetActive(true);
        isInside = true;
    }
    void OnTriggerExit(Collider other)
    {
        ui.pressEKey.SetActive(false);
        isInside = false;
    }
}
