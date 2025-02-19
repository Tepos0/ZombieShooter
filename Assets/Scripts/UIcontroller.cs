using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    [SerializeField]

    private GameObject _bulletsUI;
    [SerializeField]
    private Text _bulletsText;
    public Text BulletsText 
    {
        get {return _bulletsText;}
    }

    public void ShowABulletsUI(bool show)
    {
        _bulletsUI.SetActive(show);
    }

    public void ShowGameOverUI(bool show) 
    {
        //_gameOverUI.SetActive(show);
    }

}
