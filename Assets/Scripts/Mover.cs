using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Min(1f)] private float _speed;
    
    private Vector3 _direction;

    public void SetDirection(Vector3 direction)
    {
        direction.Normalize();
        _direction = direction;
    }
    
    private void Update()
    {
        transform.Translate(_direction * (_speed * Time.deltaTime), Space.World);
        transform.forward = _direction;
    }
}
