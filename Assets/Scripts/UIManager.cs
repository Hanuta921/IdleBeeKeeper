using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Baumenü;
    public GameObject HouseSpawner;

    // Start is called before the first frame update
    void Start()
    {
        Baumenü.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void openBaumenü() 
    {
        Baumenü.gameObject.SetActive(!Baumenü.activeSelf);
    }
    public void SpawnHouse()
    {
        Instantiate(HouseSpawner);
    }
}
