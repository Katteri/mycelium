using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _about;
    private Vector3 _position;
    private Quaternion _rotation;

    public void Play()
    {
        _mainMenu.SetActive(false);
        _position = _mainMenu.transform.position;
        _rotation = _mainMenu.transform.rotation;
        _menu.SetActive(true);
        _menu.transform.position = _position;
        _menu.transform.rotation = _rotation;
    }
    public void About()
    {
        _mainMenu.SetActive(false);
        _position = _mainMenu.transform.position;
        _rotation = _mainMenu.transform.rotation;
        _about.SetActive(true);
        _about.transform.position = _position;
        _about.transform.rotation = _rotation;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
