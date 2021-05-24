using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{
    public GameObject[] birds;

    void Update()
    {
        if (Player.isPlayerAlive)
            for(var i = 0; i < birds.Length; i++)
                if (!birds[i].activeSelf && MoneyText.Coin % 5 == 0 && Coins.isCoinCollected)
                {
                    birds[i].SetActive(true);
                    if (MoneyText.Coin % 10 == 0)
                    {
                        birds[i + 1].SetActive(true);
                        i++;
                    }
                    Coins.isCoinCollected = false;
                    break;
                }
    }
}
