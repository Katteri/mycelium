using UnityEngine;

public class AnimalMENU : MonoBehaviour
{
    [SerializeField] private GameObject _miniGame;
    [SerializeField] private MiniGame _game;
    [SerializeField] private GameObject _animal;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _base;

    public void ButtonMiniGameMENU()
    {
        _animal.SetActive(false);
        _miniGame.SetActive(true);
        _miniGame.transform.position = _animal.transform.position;
        _miniGame.transform.rotation = _animal.transform.rotation;
        _game.StartGame();
    }
    public void ButtonGoBackMENU()
    {
        _menu.SetActive(false);
        _base.SetActive(true);
        _base.transform.position = _menu.transform.position;
        _base.transform.rotation = _menu.transform.rotation;
    }

    public void ButtonMenuBASE()
    {
        _base.SetActive(false);
        _menu.SetActive(true);
        _menu.transform.position = _base.transform.position;
        _menu.transform.rotation = _base.transform.rotation;
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
