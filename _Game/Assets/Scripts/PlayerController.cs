using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(horizontal, 0, 0);
        
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }
}