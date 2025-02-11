using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
private Rigidbody _rigidBody;
[SerializeField]
    private float _bulletSpeed;

    [SerializeField]

    private int damage = 1;
    public int Damage 
    {
        get {return damage;}
    }

    private void OnEnable() 
    {
        if (_rigidBody == null)
        {
            _rigidBody = gameObject.GetComponent<Rigidbody>();
        }
        _rigidBody.AddForce(transform.forward * _bulletSpeed, ForceMode.Impulse);
    }

}
