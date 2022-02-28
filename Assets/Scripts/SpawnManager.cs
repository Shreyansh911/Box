using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject _food;
    [SerializeField] Transform _top, _bottom, _left, _right;
    [SerializeField] float _offset = 4.5f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnFood();
    }

    public void SpawnFood()
    {  
        var XBound = Random.Range(_left.position.x + _offset, _right.position.x - _offset);
        var YBound = Random.Range(_bottom.position.y + _offset, _top.position.y - _offset);

        Vector2 FoodPos = new Vector2(XBound, YBound);

        Instantiate(_food, FoodPos, Quaternion.identity);
        
     
    }
}
