using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Follower _follower;

    private Target _spawnedTarget;
    private Follower _spawnedFollower;

    public void SpawnTarget()
    {
        _spawnedTarget = Instantiate(_target, transform.position, Quaternion.identity);
        _spawnedTarget.MoveTowards(new Vector3(GetRandom(), 0, GetRandom()));
    }

    public void SpawnFollower()
    {
        _spawnedFollower = Instantiate(_follower, transform.position, Quaternion.identity);
        _spawnedFollower.Follow(_spawnedTarget);
    }
    
    private float GetRandom()
    {
        float minInclusive = -10f;
        float maxInclusive = 10f; 
        
        return Random.Range(minInclusive, maxInclusive);
    }
}
