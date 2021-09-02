using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hari15 : MonoBehaviour
{
    float y = 16.0f;
    void Update()
    {
        y -= 10.5f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 12.0f;
        }
        transform.localPosition = new Vector3(-6, y, 0);
    }
}
