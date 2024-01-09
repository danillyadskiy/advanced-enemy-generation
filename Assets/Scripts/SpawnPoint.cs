using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private SpawnTarget _spawnTarget;
    [SerializeField] private Mover _mover;

    public void Spawn()
    {
        Mover mover = Instantiate(_mover, transform.position, Quaternion.identity);
        mover.transform.LookAt(_spawnTarget.transform);
        mover.MoveTo(_spawnTarget.transform);
    }
}
