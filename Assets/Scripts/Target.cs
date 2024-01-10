using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField, Min(1f)] private float _speed;
    
    private Vector3 _direction;
    
    public float Speed => _speed;

    public void MoveTowards(Vector3 direction)
    {
        direction.Normalize();
        _direction = direction;
    }
    
    private void Update()
    {
        transform.Translate(_direction * (Speed * Time.deltaTime), Space.World);
        transform.forward = _direction;
    }
}