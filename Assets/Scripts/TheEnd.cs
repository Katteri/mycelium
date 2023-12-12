using UnityEngine;

public class TheEnd : MonoBehaviour
{
    [SerializeField] private GameObject _animal;
    [SerializeField] private HareController _controller;

    public void Restart()
    {
        gameObject.SetActive(false);
        _animal.SetActive(true);
        _animal.transform.position = gameObject.transform.position;
        _animal.transform.rotation = Quaternion.identity;
        _controller.Restart();
    }
    public void Exit()
    {
        Application.Quit();
    }
}
