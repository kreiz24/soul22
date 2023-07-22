using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testese : MonoBehaviour
{
    public Transform player;
    public Vector3 V3;
    private void Start()
    {
        
    }
    public float setSec(float sec)
    {
        return 360 / sec;
    }
    void FixedUpdate()
    {
        transform.RotateAround(V3, Vector3.up, setSec(6.0f) * Time.deltaTime);
    }
    private void Update()
    {
        
    }
}
