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

     private int _cartidgeBulletsNumber = 5;

     private int _totalBulletsNumber = 0;

     private int _currentBulletsNumber = 0;

     private Text _bulletText;
    public void Shoot()
    {
        _weaponAnimator.Play("shoot", -1, 0f);
        GameObject.Instantiate(_bullet, _bulletPivot.position, _bulletPivot.rotation);
        _currentBulletsNumber --; 
        UpdateBulletsText();
    }
    public void PickUpWeapon()
    {
        _weaponAnimator.Play("GetWeapon");
        _totalBulletsNumber = _cartidgeBulletsNumber;
        _currentBulletsNumber = _cartidgeBulletsNumber;
        UpdateBulletsText();
    }
    public void Reload()
    {
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
