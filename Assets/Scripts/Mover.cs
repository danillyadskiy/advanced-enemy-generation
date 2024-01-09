using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Min(1f)] private float _speed;
    
    private Transform _target;

    public void MoveTo(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
