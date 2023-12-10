using UnityEngine;

public class MushroomMenuBase : MonoBehaviour
{
    [SerializeField] private GameObject _base;
    [SerializeField] private GameObject _menu;

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
