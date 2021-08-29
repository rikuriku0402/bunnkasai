using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari : MonoBehaviour
{
    float y = 12.0f;
    void Update()
    {
        y -= 10.0f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 12.0f;
        }
        transform.localPosition = new Vector3(-2, y, 0);
    }
}
