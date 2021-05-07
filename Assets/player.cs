using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Theta = 0f;
    public float Delta = 2f* 3.14f / 360;
    public float radius = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Theta += Delta * Time.deltaTime;
        float x = radius * Mathf.Cos(Theta);
        float z = radius * Mathf.Sin(Theta);
        transform.position = new Vector3(500 + x, 20 , 500+z);
        
    }
}