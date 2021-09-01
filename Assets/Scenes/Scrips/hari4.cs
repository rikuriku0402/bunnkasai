using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari4 : MonoBehaviour
{
    float y = 16.0f;
    void Update()
    {
        y -= 14.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 16.0f;
        }
        transform.localPosition = new Vector3(6, y, 0);
    }
}
