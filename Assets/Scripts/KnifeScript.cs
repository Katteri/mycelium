using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    [SerializeField] private MiniGame _miniGame;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("mushroom"))
        {
            Destroy(collider.gameObject);
            _miniGame.Score();
        }
    }
}
