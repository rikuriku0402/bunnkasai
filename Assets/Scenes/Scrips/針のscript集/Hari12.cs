using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hari12 : MonoBehaviour
{
    float y = 12.0f;
    void Update()
    {
        y -= 11.6f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 12.0f;
        }
        transform.localPosition = new Vector3(-13.4f, y, 0);
    }
}
