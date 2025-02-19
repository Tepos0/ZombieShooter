using System;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Health health;

    private bool isPlaying = true;

    private UIcontroller uicontroller;

    private void Start() 
    {
        health = GetComponent<Health>();
        SoundManager.instance.PlayMusic("Fondo");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && isPlaying)
        {
            health.TakeDamage(1);
            Vector3 pushDirection = (transform.position - collision.transform.position).normalized;
            transform.position += pushDirection * 0.5F;
        }

        else if(collision.gameObject.CompareTag("Key"))
        {
            isPlaying = false;
            //uiController.showWinUi(true)
        }
    }

    public void Die()

{ 
    
        uicontroller.ShowGameOverUI(true);
        SoundManager.instance.StopMusic();
        isPlaying = false;
        SoundManager.instance.Play("Muerte");
}


}
