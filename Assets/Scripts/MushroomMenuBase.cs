using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMenuBase : MonoBehaviour
{
    public GameObject _base;
    public GameObject _menu;

    public void Menu()
    {
        _base.SetActive(false);
        _menu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
