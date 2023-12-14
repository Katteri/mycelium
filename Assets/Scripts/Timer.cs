using UnityEngine;

//накидывается на HareCollection
public class Timer : MonoBehaviour
{
    [SerializeField] HareController controller;
    private float _timeStartHealth = 40;
    private float _timeStartMood = 20;
    void Update()
    {
        _timeStartHealth -= Time.deltaTime;
        _timeStartMood -= Time.deltaTime;

        if (_timeStartHealth <= 0)
        {
            _timeStartHealth = 30;
            controller.NotEating();
        }

        if (_timeStartMood <= 0)
        {
            _timeStartMood = 60;
            controller.NotMood();
        }
    }
}