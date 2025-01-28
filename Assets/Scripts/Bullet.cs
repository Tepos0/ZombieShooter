using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
private Rigidbody _rigidBody;
[SerializeField]
    private float _bulletSpeed;

    private void OnEnable() 
    {
        if (_rigidBody == null)
        {
            _rigidBody = gameObject.GetComponent<Rigidbody>();
        }
        _rigidBody.AddForce(transform.forward * _bulletSpeed, ForceMode.Impulse);
    }

}
