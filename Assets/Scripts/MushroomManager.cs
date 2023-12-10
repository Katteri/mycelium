using UnityEngine;

public class MushroomManager : MonoBehaviour
{
    [SerializeField] private GameObject _m1;
    [SerializeField] private GameObject _m2;
    [SerializeField] private GameObject _m3;
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _rain;
    [SerializeField] private GameObject _seeds;

    [SerializeField] private GameObject _animal;
    private int _grow = 0;

    void Check()
    {
        if (_grow == 1)
        {
            Invoke("Change1to2", 5f);
        } else if (_grow == 2)
        {
            Invoke("Change2to3", 5f);
        } else if (_grow == 3)
        {
            gameObject.SetActive(false);
            _animal.SetActive(true);
            _animal.transform.position = gameObject.transform.position;
            _animal.transform.rotation = gameObject.transform.rotation;
        }
    }
    public void GrowMoment()
    {
        _grow += 1;
        GameObject seed = Instantiate(_seeds);
        seed.transform.SetParent(_parent.transform, false);

        Check();

    }
    public void Rain()
    {
        _grow += 1;
        GameObject water = Instantiate(_rain, _parent.transform.position, Quaternion.identity);
        water.transform.SetParent(_parent.transform, false);
        Destroy(water, 10);
        Check();
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
