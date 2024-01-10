using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;

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
            spawnPoint.SpawnTarget();
            yield return wait;

            spawnPoint.SpawnFollower();
            yield return wait;
        }
    }
}
