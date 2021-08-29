using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari3 : MonoBehaviour
{
    float y = 14.0f;
    void Update()
    {
        y -= 12.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 14.0f;
        }
        transform.localPosition = new Vector3(4, y, 0);
    }
}
