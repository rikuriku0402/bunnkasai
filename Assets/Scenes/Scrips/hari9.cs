using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari9 : MonoBehaviour
{
    float y = 1.0f;
    void Update()
    {
        y -= 4.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 7.0f;
        }
        transform.localPosition = new Vector3(14, y, 0);
    }
}
