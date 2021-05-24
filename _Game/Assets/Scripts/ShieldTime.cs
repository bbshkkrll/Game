using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldTime : MonoBehaviour
{
    public Text ShieldText;
    public GameObject TextField;

    void Update()
    {
        if (Shield.isShieldActieve)
        {
            TextField.SetActive(true);
            ShieldText.text = "End in: " + Shield.time.ToString().Remove(4);
        }
        else TextField.SetActive(false);
    }
}
