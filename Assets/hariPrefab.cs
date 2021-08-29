using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hariPrefab : MonoBehaviour
{
    public GameObject HariPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            Destroy(this.gameObject);
        }


        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(HariPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
        
    }
}
