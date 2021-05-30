using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonsText : MonoBehaviour
{
    public static int Balloon;
    static Text Redtext;
    void Start()
    {
        Redtext = GetComponent<Text>();
    }

    void Update()
    {
        Redtext.text = Balloon.ToString() + "/10";
    }

    public static void ResetCount()
    {
        Balloon = 0;
    }
}