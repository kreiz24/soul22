using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatIsland : MonoBehaviour
{
    public float height;
    private void Update()
    {
     transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.Sin(Time.fixedTime) * height, transform.position.z);
    }
}
