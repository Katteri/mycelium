using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private GameObject _StartHealth;
    [SerializeField] private GameObject _StartMood;
    [SerializeField] private GameObject _sliderButtonHealth;
    [SerializeField] private GameObject _sliderButtonMood;
    [SerializeField] private TextMeshPro _valueHealth;
    [SerializeField] private TextMeshPro _valueMood;
    [SerializeField] private HareController _hareController;
    private int _amountOfHealthValue;
    private int _amountOfMoodValue;
    private double _hxposition;
    private double _mxposition;

    //void Update()
    //{
    //    _amountOfHealthValue = _hareController._health;
    //    _amountOfMoodValue = _hareController._mood;

    //    _valueHealth.text = _amountOfHealthValue.ToString();
    //    _valueMood.text = _amountOfMoodValue.ToString();

    //    _hxposition = 0.002286*_amountOfHealthValue;

    //    _mxposition = 0.002286 * _amountOfMoodValue;

    //    _sliderButtonHealth.transform.localPosition = new Vector3(_StartHealth.transform.localPosition.x + (float)_hxposition, _StartHealth.transform.localPosition.y, _StartHealth.transform.localPosition.z);
    //    _sliderButtonMood.transform.localPosition = new Vector3(_StartMood.transform.localPosition.x + (float)_mxposition, _StartMood.transform.localPosition.y, _StartMood.transform.localPosition.z);
    //}
    private void Start()
    {
        UpdateSprite();
    }


    public void UpdateSprite()
    {
        _amountOfHealthValue = _hareController._health;
        _amountOfMoodValue = _hareController._mood;

        _valueHealth.text = _amountOfHealthValue.ToString();
        _valueMood.text = _amountOfMoodValue.ToString();

        _hxposition = 0.002286 * _amountOfHealthValue;

        _mxposition = 0.002286 * _amountOfMoodValue;

        _sliderButtonHealth.transform.localPosition = new Vector3(_StartHealth.transform.localPosition.x + (float)_hxposition, _StartHealth.transform.localPosition.y, _StartHealth.transform.localPosition.z);
        _sliderButtonMood.transform.localPosition = new Vector3(_StartMood.transform.localPosition.x + (float)_mxposition, _StartMood.transform.localPosition.y, _StartMood.transform.localPosition.z);
    }
}
