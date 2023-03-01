using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth;

    public int MaxHunger = 100;
    public int CurrentHunger;
    public static PlayerStats pStats;
    public Health HealthBar;
    public Text HealthCount;

    public Hunger HungerBar;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        HealthBar.SetMaxHealth(MaxHealth);
        HealthCount = GetComponent<Text>();
        
        CurrentHunger = MaxHunger;
        HungerBar.SetMaxHunger(MaxHunger);
    }

    private void Awake()
    {
        pStats = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) {
            TakeDamage(20);
        }
        HungerBar.SetHunger(CurrentHunger);

        if(CurrentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        HealthBar.SetHealth(CurrentHealth);
    }

    public void Eat(int foodValue){
        CurrentHunger += foodValue;
        HungerBar.SetHunger(CurrentHunger);
    }
}
