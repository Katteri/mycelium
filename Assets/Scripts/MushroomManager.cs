using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomManager : MonoBehaviour
{
    public GameObject _m1;
    public GameObject _m2;
    public GameObject _m3;
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _rain;
    [SerializeField] private GameObject _seeds;
    private int _grow = 0;

    void Update()
    {
        if (_grow == 1)
        {
            Invoke("Change1to2", 5f);
        } else if (_grow == 2)
        {
            Invoke("Change2to3", 5f);
        } else if (_grow == 3)
        {
            //¿’”≈“‹ Ÿ¿ ¡”ƒ≈“ —”Ÿ≈—“¬Œ ∆»¬Œ≈ œ–» »Õ‹“≈
        }
    }
    public void GrowMoment()
    {
        _grow += 1;
        GameObject seed = Instantiate(_seeds);
        seed.transform.SetParent(_parent.transform, false);

    }
    public void Rain()
    {
        _grow += 1;
        GameObject water = Instantiate(_rain, _parent.transform.position, Quaternion.identity);
        water.transform.SetParent(_parent.transform, false);
    }

    void Change1to2()
    {
        _m1.SetActive(false);
        _m2.SetActive(true);
    }

    void Change2to3()
    {
        _m2.SetActive(false);
        _m3.SetActive(true);
    }
}
