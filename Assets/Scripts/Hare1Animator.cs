using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hare1Animator : MonoBehaviour
{
    [SerializeField] private Animator _animator; 
    public static readonly int Death = Animator.StringToHash("IsDead");
    public static readonly int Eat = Animator.StringToHash("IsEating");
    public static readonly int Drink = Animator.StringToHash("IsDrinking"); //не используется
    public static readonly int Play = Animator.StringToHash("IsPlaying");
    public static readonly int Sad = Animator.StringToHash("IsSad");

    public void IsDead()
    {
        _animator.SetTrigger(Death);
        Invoke("Delete", 1f);
    }

    public void IsEating()
    {
        _animator.SetTrigger(Eat);
    }

    public void IsDrinking()
    {
        _animator.SetTrigger(Drink);
    }

    public void IsPlaying(int random)
    {
        _animator.SetInteger(Play, random);
    }

    public void IsSad(int random)
    {
        _animator.SetInteger(Sad, random);
    }

    private void Delete()
    {
        gameObject.SetActive(false);
    }
}
