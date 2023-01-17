using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blocklist = new List<GameObject>();
    private GameObject lastBlokObjeckt;


    void Start()
    {
        UpdateLastBlockObject();
    }

    
     
    public void IncreaseBlockStack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlokObjeckt.transform.position.x, lastBlokObjeckt.transform.position.y - 2f, lastBlokObjeckt.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blocklist.Add(_gameObject);
        UpdateLastBlockObject();
    }

    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blocklist.Remove(_gameObject);
        UpdateLastBlockObject();
    }

    private void UpdateLastBlockObject()
    {
        lastBlokObjeckt = blocklist[blocklist.Count - 1];
    }
}
