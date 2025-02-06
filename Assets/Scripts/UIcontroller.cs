using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    [SerializeField]

    private GameObject _bulletsUI;

    private void ShowNulletsUI(bool show)
    {
        _bulletsUI.SetActive(show);
    }


}
