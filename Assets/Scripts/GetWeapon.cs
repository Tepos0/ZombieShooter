using System.Runtime.CompilerServices;
using UnityEngine;

public class GetWeapon : MonoBehaviour
{
    private Gun _weapon;
    public Gun Weapon 
    {
        get {return _weapon;}
    }
     
    [SerializeField]
    private Transform _gunPivot;

    private UIcontroller _uiController;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Weapon") && _weapon == null) 
        {
          GrabWeapond(other.transform);
        }
    }

private void GrabWeapond (Transform weapon)
{
    weapon.GetComponent<Rotate>().IsRotating= false;
    weapon.GetComponent<BoxCollider>().enabled= false;
    weapon.SetParent(_gunPivot);
    weapon.localPosition = Vector3.zero;
    weapon.localRotation = Quaternion.identity;
    _weapon = weapon.GetComponent<Gun>();
    _weapon.PickUpWeapon(this);
    _uiController.ShowABulletsUI(true);
}
public void RemoveWeapon() 
{
    Destroy(_weapon.gameObject);
    _weapon = null;
    _uiController.ShowABulletsUI(false);
}


}
