using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SawDir : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool rightDir = true;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rightDir)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if(timer >= moveTime)
        {
            rightDir = !rightDir;
            timer = 0f;
        }
    }
}
