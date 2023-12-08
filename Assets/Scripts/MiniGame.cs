using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MiniGame : MonoBehaviour
{
    [SerializeField] private GameObject _animal;

    [SerializeField] private GameObject _knife;

    [SerializeField] private GameObject _poisonMushroom;

    [SerializeField] private HareController _controller;
    [SerializeField] private TextMeshPro _score;
    public int _amountOfWin;
    private Vector3 _position;

    public void StartGame()
    {
        //_knife.transform.position = gameObject.transform.position;
        _position = Camera.main.transform.position + Camera.main.transform.forward * 1.5f;
        
        //_position = gameObject.transform.position;
        _knife.transform.position = _position;

        _amountOfWin = 0;
        _score.text = "WIN: " + _amountOfWin.ToString();
        InvokeRepeating("Spawn", 0.2f, 0.5f);
    }

    public void Score()
    {
        _amountOfWin++;
        _score.text = "WIN: " + _amountOfWin.ToString();
    }
    private void Spawn()
    {
        GameObject Mushroom = Instantiate(_poisonMushroom, new Vector3(Random.Range(-(_position.x + 1.5f), (_position.x + 1.5f)), _position.y + 0.7f, _position.z), Quaternion.identity);
        Destroy(Mushroom, 3);
    }

    public void StopGameButton()
    {
        _controller.EarnMoney(_amountOfWin * 10);
        CancelInvoke();
        gameObject.SetActive(false);
        _animal.SetActive(true);
        _animal.transform.position = gameObject.transform.position;
        _animal.transform.rotation = gameObject.transform.rotation;

        GameObject[] prefabs = GameObject.FindGameObjectsWithTag("mushroom");
        foreach (GameObject prefab in prefabs)
        {
            Destroy(prefab);
        }
    }
}
