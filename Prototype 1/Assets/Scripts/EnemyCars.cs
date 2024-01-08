using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCars : MonoBehaviour
{
    float speed = 30.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
