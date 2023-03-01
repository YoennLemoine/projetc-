using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;

    public SliderController SController;


    

    public void SetMaxHealth(int Health)
    {
        slider.maxValue= Health;
        slider.value= Health;
    }

    public void SetHealth(int Health)
    {
        slider.value = Health;
    }
}
