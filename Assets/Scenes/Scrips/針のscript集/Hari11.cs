﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hari11 : MonoBehaviour
{
    float y = 12.0f;
    void Update()
    {
        y -= 9.5f * Time.deltaTime;

        if (y < 0.0f)
        {
            y = 12.0f;
        }
        transform.localPosition = new Vector3(-15, y, 0);
    }
}
