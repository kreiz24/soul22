using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private bool _isOpen;
    [SerializeField] private Transform _door;
    [SerializeField] private Transform _point;

    private void Start()
    {
        _door = transform.GetChild(0);
        _point = transform.GetChild(1);
    }
    public void Open()
    {
        _isOpen = true;
    }
    private void Update()
    {
        if(_isOpen)
        {

            _door.position = Vector3.Lerp(_door.position,_point.position, 0.2f * Time.deltaTime);
        }  
        
    }
}

