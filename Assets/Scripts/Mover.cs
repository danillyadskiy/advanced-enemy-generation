using UnityEngine;

public class Mover : MonoBehaviour
{
    private readonly float _speed = 0.01f;
    
    private void Update()
    {
        transform.Translate(0, 0, _speed);
    }
}
