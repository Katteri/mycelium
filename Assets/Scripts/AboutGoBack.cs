using UnityEngine;

public class AboutGoBack : MonoBehaviour
{
    public GameObject _mainMenu;
    public GameObject _about;
    public void GoBackButton()
    {
        _about.SetActive(false);
        _mainMenu.SetActive(true);
        _mainMenu.transform.position = _about.transform.position;
        _mainMenu.transform.rotation = _about.transform.rotation;
    }
}
