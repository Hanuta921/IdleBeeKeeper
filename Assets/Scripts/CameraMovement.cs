using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 touchStart;
    public Camera cam;
    [SerializeField] float minZoom = 1f;
    [SerializeField] float maxZoom = 8f;
    [SerializeField] float minBoundX;
    [SerializeField] float maxBoundX;
    [SerializeField] float minBoundY;
    [SerializeField] float maxBoundY;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = GetWorldPosititon(0);
        }
        if(Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos- touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * 0.01f);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 postition = touchStart - GetWorldPosititon(0);
            cam.transform.position += postition;
            Mathf.Clamp(cam.transform.position.x, minBoundX,maxBoundX);
            Mathf.Clamp(cam.transform.position.y, minBoundY, maxBoundY);
        }

    }
    private Vector3 GetWorldPosititon(float z)
    {
        Ray mousePos = cam.ScreenPointToRay(Input.mousePosition);
        Plane groundZ = new Plane(Vector3.forward, new Vector3(0, 0, z));
        float distance;
        groundZ.Raycast(mousePos, out distance);
        return mousePos.GetPoint(distance);
    }
    private void zoom(float increment)
    {
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - increment,minZoom,maxZoom);
    }
}
