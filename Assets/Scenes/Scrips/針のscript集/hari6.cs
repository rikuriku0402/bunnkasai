using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari6 : MonoBehaviour
{
    float y = 8.0f;
    void Update()
    {
        y -= 8.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 8.0f;
        }
        transform.localPosition = new Vector3(8, y, 0);
    }
}
