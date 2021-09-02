using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari1 : MonoBehaviour
{
    float y = 10.0f;
    void Update()
    {
        y -= 8.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 10.0f;
        }
        transform.localPosition = new Vector3(1, y, 0);
    }
}
