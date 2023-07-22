using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatIsland : MonoBehaviour
{
    public float height;
    public float speedRotate;
    private void FixedUpdate()
    {
     transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.Sin(Time.fixedTime) * height, transform.position.z);
        transform.Rotate(0, speedRotate, 0);
    }
}
