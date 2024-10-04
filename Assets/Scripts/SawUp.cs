using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SawUp : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool upDir = true;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(upDir)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if(timer >= moveTime)
        {
            upDir = !upDir;
            timer = 0f;
        }
    }
}
