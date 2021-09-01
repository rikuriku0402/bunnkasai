using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari7 : MonoBehaviour
{
    float y = 20.0f;
    void Update()
    {
        y -= 20.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 20.0f;
        }
        transform.localPosition = new Vector3(10, y, 0);
    }
}
