using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari8 : MonoBehaviour
{
    float y = 24.0f;
    void Update()
    {
        y -= 10.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 23.0f;
        }
        transform.localPosition = new Vector3(12, y, 0);
    }
}
