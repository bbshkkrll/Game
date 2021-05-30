using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public static int Coin;
    static Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = Coin.ToString() + '/' + MoveSky.finishCount;
    }
    public static void ResetCount()
    {
        Coin = 0;
    }
}
