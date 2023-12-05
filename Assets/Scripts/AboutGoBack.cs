using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutGoBack : MonoBehaviour
{
    public GameObject _mainMenu;
    public GameObject _about;
    private Vector3 _position;
    private Quaternion _rotation;

    public void GoBackButton()
    {
        _about.SetActive(false);
        _position = _about.transform.position;
        _rotation = _about.transform.rotation;
        _mainMenu.SetActive(true);
        _mainMenu.transform.position = _position;
        _mainMenu.transform.rotation = _rotation;
    }
}
