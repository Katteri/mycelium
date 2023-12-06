using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

//накидывается на HareCollection
public class Timer : MonoBehaviour
{
    [SerializeField] HareController controller;
    private float _timeStartHealth;
    private float _timeStartMood;
    void Update()
    {
        _timeStartHealth = 40;
        _timeStartMood = 20;
        _timeStartHealth -= Time.deltaTime;
        _timeStartMood -= Time.deltaTime;

        if (_timeStartHealth < 0)
        {
            _timeStartHealth = 0;
            controller.NotEating();
        }

        if (_timeStartMood < 0)
        {
            _timeStartMood = 0;
            controller.NotMood();
        }
    }
}