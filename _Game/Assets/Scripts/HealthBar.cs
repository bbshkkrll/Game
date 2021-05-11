using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(float heath)
    {
        slider.maxValue = heath;
        slider.value = heath;
    }
    
    public void SetHealth(float health)
    {
        slider.value = health;
    }
}