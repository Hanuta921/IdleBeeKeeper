using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Baumen�;
    public GameObject HouseSpawner;

    // Start is called before the first frame update
    void Start()
    {
        Baumen�.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void openBaumen�() 
    {
        Baumen�.gameObject.SetActive(!Baumen�.activeSelf);
    }
    public void SpawnHouse()
    {
        Instantiate(HouseSpawner);
    }
}
