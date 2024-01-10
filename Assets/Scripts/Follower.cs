using UnityEngine;

public class Follower : MonoBehaviour
{
    private Target _target;
    
    public void Follow(Target target)
    {
        _target = target;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _target.Speed * Time.deltaTime);
        transform.LookAt(_target.transform);
    }
}
