using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari5 : MonoBehaviour
{
    float y = 30.0f;
    void Update()
    {
        y -= 7.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 29.0f;
        }
        transform.localPosition = new Vector3(16, y, 0);
    }
}
