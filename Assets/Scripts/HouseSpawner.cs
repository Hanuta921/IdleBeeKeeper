using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSpawner : MonoBehaviour
{
    RaycastHit hit;
    Vector3 movePos;
    public GameObject Haus;
    // Start is called before the first frame update
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

        if(Physics.Raycast(ray, 500000f, 1 << 8))
        {
            transform.position = hit.point;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
