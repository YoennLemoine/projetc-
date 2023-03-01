using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    public PlayerStats playerStats;

    float lastHungerUpdateTime = 0.0f;
    float currentTime;

    public Slider slider;

    private void Update()
    {
        currentTime = Time.time;
        if (currentTime - lastHungerUpdateTime > 1.0f)
        {
            playerStats.CurrentHunger -= 1;
            lastHungerUpdateTime = currentTime;
        }
    }
    public void SetMaxHunger(int Hunger)
    {
        slider.maxValue = Hunger;
        slider.value = Hunger;
    }

    public void SetHunger(int Hunger)
    {
        slider.value = Hunger;
    }
}
