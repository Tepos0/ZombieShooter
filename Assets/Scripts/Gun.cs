using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
   [SerializeField]
   
    private GameObject _bullet;
    [SerializeField]
    private Transform _bulletPivot;
     [SerializeField]
     private Animator _weaponAnimator;
     [SerializeField]

     private int _maxBulletsNumber = 20;
     [SerializeField]

     private int _cartidgeBulletsNumber = 35;

     private int _totalBulletsNumber = 0;

     private int _currentBulletsNumber = 0;

     private Text _bulletText;
     private GetWeapon _getWeapon;

     private void RemoveWeapon () 
     {
        _getWeapon.RemoveWeapon ();
        _getWeapon = null;
        gameObject.GetComponent<UIcontroller
     }
    public void Shoot()
    {
        if (_currentBulletsNumber == 0)
        {
            if (_totalBulletsNumber == 0)
            {
                RemoveWeapon();
            }
            return;
        }
        _weaponAnimator.Play("shoot", -1, 0f);
        GameObject.Instantiate(_bullet, _bulletPivot.position, _bulletPivot.rotation);
        _currentBulletsNumber --; 
        UpdateBulletsText();

    }
    public void PickUpWeapon(GetWeapon getWeapon)
    {
        _getWeapon = getWeapon; 
        _weaponAnimator.Play("GetWeapon");
        _totalBulletsNumber = _cartidgeBulletsNumber;
        _currentBulletsNumber = _cartidgeBulletsNumber;
        UpdateBulletsText();
    }
    public void Reload()
    {
        if(_currentBulletsNumber == _cartidgeBulletsNumber || _totalBulletsNumber ==0)
        {
            return;
        }
        int bulletsNeeded = _cartidgeBulletsNumber - _currentBulletsNumber;

        if (_totalBulletsNumber >= _cartidgeBulletsNumber) 
        {
            _currentBulletsNumber = _cartidgeBulletsNumber;
        } 
        else if (_totalBulletsNumber >0)
        {
            _currentBulletsNumber = _totalBulletsNumber;
        }
        _totalBulletsNumber -= _currentBulletsNumber;
        UpdateBulletsText();

        _weaponAnimator.Play("Reload");

    }
    private void UpdateBulletsText()
    {
        if (_bulletText == null)
        {
            _bulletText = GameObject.Find("BulletsText").GetComponent<Text>();
        }
        _bulletText.text = _currentBulletsNumber + "/" + _totalBulletsNumber;
    }

}
