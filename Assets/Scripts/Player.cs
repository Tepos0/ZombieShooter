using System;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Health health;

    private UIcontroller uicontroller;

    private void Start() 
    {
        health = GetComponent<Health>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health.TakeDamage(1);
            Vector3 pushDirection = (transform.position - collision.transform.position).normalized;
            transform.position += pushDirection * 0.5F;
        }
    }

    public void Die()

{
    uicontroller.ShowGameOverUI(true);
}


}
