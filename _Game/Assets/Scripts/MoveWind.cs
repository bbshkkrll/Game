using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWind : MonoBehaviour
{
    public float speed = 2f;
    public void FixedUpdate()
    {
        transform.Translate(Vector3.right * (speed * Time.deltaTime));
    }
}
