using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private Mover _mover;

    private readonly int _waitingSpawnSeconds = 2;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds wait = new WaitForSeconds(_waitingSpawnSeconds);

        foreach (SpawnPoint spawnPoint in _spawnPoints)
        {
            Mover mover = Instantiate(_mover, spawnPoint.transform.position, Quaternion.identity);
            mover.SetDirection(new Vector3(GetRandom(), 0, GetRandom()));
            
            yield return wait;
        }
    }

    private float GetRandom()
    {
        float minInclusive = -10f;
        float maxInclusive = 10f; 
        
        return Random.Range(minInclusive, maxInclusive);
    }
}
