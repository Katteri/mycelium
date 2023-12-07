using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HareController : MonoBehaviour
{
    [SerializeField] private GameObject Hare1;
    [SerializeField] private GameObject Hare2;
    [SerializeField] private Hare1Animator _hare1Animator;
    [SerializeField] private TextMeshPro _healthText;
    [SerializeField] private TextMeshPro _moodText;
    public int _health = 90; //for controlling sliders
    public int _mood = 90;

    private int _Circle; //for growing up

    private HareState _hareState;

    private void Start()
    {
        _hareState = HareState.Hare1;
    }
    private void Update()
    {
        _healthText.text = "HEALTH: " + _health.ToString();
        _moodText.text = "MOOD: " + _mood.ToString();
        if (_health == 0 || _mood == 0)
        {
            _hare1Animator.IsDead();
        }

        switch (_hareState)
        {
            case HareState.Hare1:
                if (_health == 100 || _mood == 100)
                {
                    _Circle += 1;
                    if (_Circle == 5)
                    {
                        Hare1.SetActive(false);
                        Hare2.SetActive(true);
                        _hareState = HareState.Hare2;
                    }
                }
                break;

            case HareState.Hare2:
                //рост зайца на этом кончается
                break;
        }
    }

    public void Eating() //кнопка кормления
    {
        switch (_hareState)
        {
            case HareState.Hare1:
                _hare1Animator.IsEating();
                break;
            case HareState.Hare2:
                break;
        }

        if (_health + 20 >= 100)
        {
            _health = 100;
        } else
        {
            _health += 20;
        }
    }

    public void ButtonMood() //кнопка игры
    {
        switch (_hareState)
        {
            case HareState.Hare1:
                _hare1Animator.IsPlaying(Random.Range(1, 5));
                break;
            case HareState.Hare2:
                break;
        }

        if (_mood + 20 >= 100)
        {
            _mood = 100;
        } else
        {
            _health += 20;
        }
    }

    public void NotEating()
    {
        switch (_hareState)
        {
            case HareState.Hare1:
                _hare1Animator.IsSad(2);
                break;
            case HareState.Hare2:
                break;
        }

        if (_health - 25 <= 0)
        {
            _health = 0;
        } else
        {
            _health -= 25;
        }
    }

    public void NotMood()
    {
        switch (_hareState)
        {
            case HareState.Hare1:
                _hare1Animator.IsSad(1);
                break;
            case HareState.Hare2:
                break;
        }

        if (_mood - 25 <= 0)
        {
            _mood = 0;
        } else
        {
            _mood -= 10;
        }
    }

    public enum HareState
    {
        Hare1,
        Hare2
    }
}
