using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class MushroomMenu : MonoBehaviour
{
    [SerializeField] private MushroomManager _mManager;
    [SerializeField] private GameObject _base;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _buttonOne;
    [SerializeField] private GameObject _buttonTwo;

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
