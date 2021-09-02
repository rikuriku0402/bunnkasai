using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hari13 : MonoBehaviour
{
    float y = 12.0f;
    void Update()
    {
        y -= 8.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 12.0f;
        }
        transform.localPosition = new Vector3(-10, y, 0);
    }
}
