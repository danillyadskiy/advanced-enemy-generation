using System;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    public void Spawn()
    {
        Instantiate(_gameObject, transform);
    }
    
    private void Start()
    {
        MakeRandomRotationY();
    }

    private void MakeRandomRotationY()
    {
        System.Random random = new System.Random();
        
        int minRotationAngle = 0;
        int maxRotationAngle = 360;
        int rotationAngle = random.Next(minRotationAngle, maxRotationAngle + 1);

        transform.Rotate(0, rotationAngle, 0);
    }
}
