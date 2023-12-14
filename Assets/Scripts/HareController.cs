using TMPro;
using UnityEngine;

public class HareController : MonoBehaviour
{
    [SerializeField] private GameObject Hare1;
    [SerializeField] private GameObject Hare2;
    [SerializeField] private Hare1Animator _hare1Animator;
    [SerializeField] private SliderScript _sliderScript;
    [SerializeField] private TextMeshPro _error;
    public int _health = 90; //for controlling sliders
    public int _mood = 90;

    [SerializeField] private GameObject _parentRain;
    [SerializeField] private GameObject _parentEat;
    [SerializeField] private GameObject _rain;
    [SerializeField] private GameObject _seeds;

    [SerializeField] private MiniGame _miniGame;
    [SerializeField] private TextMeshPro _money;
    public int _amountOfMoney;

    private int _Circle = 0; //for growing up

    private HareState _hareState;

    [SerializeField] private GameObject _animal;
    [SerializeField] private GameObject _theEnd;

    private void Start()
    {
        _hareState = HareState.Hare1;
        _money.text = "MONEY: " + _amountOfMoney.ToString();
    }

    private void Check()
    {
        if (_health == 0 || _mood == 0)
        {
            _hare1Animator.IsDead();
            Invoke("TheEndOfGame", 2);
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
        if (_amountOfMoney - 100 >= 0)
        {
            if (_health < 100)
            {
                _parentEat.SetActive(true);
                Invoke("Stop", 13);
                GameObject seed = Instantiate(_seeds);
                seed.transform.SetParent(_parentEat.transform, false);

                switch (_hareState)
                {
                    case HareState.Hare1:
                        //_hare1Animator.IsEating();
                        _hare1Animator.Invoke("IsEating", 5);
                        break;
                    case HareState.Hare2:
                        break;
                }

                if (_health + 20 >= 100)
                {
                    _health = 100;
                }
                else
                {
                    _health += 20;
                }

                _amountOfMoney -= 100;
                _money.text = "MONEY: " + _amountOfMoney.ToString();
                _sliderScript.UpdateSprite();
                Check();
            }
            else
            {
                _error.text = "YOUR PET IS NOT HUNGRY!";
                Invoke("Deactive", 2);

            }
        }
        else
        {
            _error.text = "NOT ENOUGH MONEY!";
            Invoke("Deactive", 2);
        }
    }

    public void Drink()
    {
        

        if (_health < 100)
        {
            _parentRain.SetActive(true);
            Invoke("Stop", 14);
            GameObject water = Instantiate(_rain, new Vector3 (_parentRain.transform.localPosition.x, _parentRain.transform.localPosition.y, (float)(_parentRain.transform.localPosition.z - 0.3565863)), Quaternion.identity);
            water.transform.SetParent(_parentRain.transform, false);
            Destroy(water, 10);

            switch (_hareState)
            {
                case HareState.Hare1:
                    //_hare1Animator.IsDrinking();
                    _hare1Animator.Invoke("IsDrinking", 5);
                    break;
                case HareState.Hare2:
                    break;
            }

            if (_health + 20 >= 100)
            {
                _health = 100;
            }
            else
            {
                _health += 20;
            }

            _amountOfMoney -= 100;
            _money.text = "MONEY: " + _amountOfMoney.ToString();
            _sliderScript.UpdateSprite();
            Check();
        }
        else
        {
            _error.text = "YOUR PET IS NOT THIRSTY!";
            Invoke("Deactive", 2);
        }
    }

    private void Stop()
    {
        _parentEat.SetActive(false);
        _parentRain.SetActive(false);
    }
    public void ButtonMood() //кнопка игры
    {
        if (_mood < 100)
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
            }
            else
            {
                _mood += 20;
            }

            _amountOfMoney += 50;
            _money.text = "MONEY: " + _amountOfMoney.ToString();
            _sliderScript.UpdateSprite();
            Check();
        }
        else
        {
            _error.text = "YOUR PET IS NOT SAD!";
            Invoke("Deactive", 2);
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

        _sliderScript.UpdateSprite();
        Check();
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

        _sliderScript.UpdateSprite();
        Check();
    }

    private void Deactive()
    {
        _error.text = "";
    }

    public void EarnMoney(int m)
    {
        _amountOfMoney += m;
        _money.text = "MONEY: " + _amountOfMoney.ToString();
    }

    private void TheEndOfGame()
    {
        _animal.gameObject.SetActive(false);
        _theEnd.gameObject.SetActive(true);
        _theEnd.transform.position = gameObject.transform.position;
        _theEnd.transform.rotation = gameObject.transform.rotation;
    }

    public void Restart()
    {
        _hareState = HareState.Hare1;
        _health = 90;
        _mood = 90;
        _amountOfMoney = 1000;
        _Circle = 0;
        _money.text = "MONEY: " + _amountOfMoney.ToString();
    }
    public enum HareState
    {
        Hare1,
        Hare2
    }
}
