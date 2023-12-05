using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMenu : MonoBehaviour
{
    [SerializeField] MushroomManager _mManager;
    public GameObject _base;
    public GameObject _menu;

    public void Eat()
    {
        _mManager.GrowMoment();
    }

    public void Water()
    {
        _mManager.Rain();
    }

    public void GoBack()
    {
        _menu.SetActive(false);
        _base.SetActive(true);
    }
}
