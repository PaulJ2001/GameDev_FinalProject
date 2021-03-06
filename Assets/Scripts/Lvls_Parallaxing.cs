using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvls_Parallaxing : MonoBehaviour
{
    private float length, start;
    [SerializeField] private Camera c;
    [SerializeField] private float effect;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (c.transform.position.x * (1 - effect));
        float dist = (c.transform.position.x *  effect);
        transform.position = new Vector3(start + dist, transform.position.y, 
            transform.position.z);

        if(temp > start + length)
        {
            start += length;
        }
        else if (temp < start - length)
        {
            start -= length;
        }
    }
}
