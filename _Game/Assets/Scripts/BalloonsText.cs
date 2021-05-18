using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalloonsText : MonoBehaviour
{
    public static int Balloon;
    Text Redtext;
    void Start()
    {
        Redtext = GetComponent<Text>();
    }

    void Update()
    {
        Redtext.text = Balloon.ToString();
    }
}