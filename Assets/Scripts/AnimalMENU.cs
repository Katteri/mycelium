using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMENU : MonoBehaviour
{
    [SerializeField] private GameObject _miniGame;
    [SerializeField] private MiniGame _game;
    [SerializeField] private GameObject _animal;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _base;
    private Vector3 _position;
    private Quaternion _rotation;

    public void ButtonMiniGameMENU()
    {
        _animal.SetActive(false);
        _position = _animal.transform.position;
        _rotation = _animal.transform.rotation;
        _miniGame.SetActive(true);
        _miniGame.transform.position = _position;
        _miniGame.transform.rotation = _rotation;
        _game.StartGame();
    }
    public void ButtonGoBackMENU()
    {
        _menu.SetActive(false);
        _position = _menu.transform.position;
        _rotation = _menu.transform.rotation;
        _base.SetActive(true);
        _base.transform.position = _position;
        _base.transform.rotation = _rotation;
    }

    public void ButtonMenuBASE()
    {
        _base.SetActive(false);
        _position = _base.transform.position;
        _rotation = _base.transform.rotation;
        _menu.SetActive(true);
        _menu.transform.position = _position;
        _menu.transform.rotation = _rotation;
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
