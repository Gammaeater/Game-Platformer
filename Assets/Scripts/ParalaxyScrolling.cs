using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxyScrolling : MonoBehaviour
{
    public Transform cameraTransform;
    public float parallaxFactor;

    private Vector3 precCameraPositrion;
    private Vector3 deltaCameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        precCameraPositrion = cameraTransform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaCameraPosition = cameraTransform.position - precCameraPositrion;
        Vector3 parallaxPositrion = new Vector3(transform.position.x + (deltaCameraPosition.x * parallaxFactor),transform.position.y, transform.position.x);
        transform.position = parallaxPositrion;
        precCameraPositrion = cameraTransform.position;
        
    }
}
