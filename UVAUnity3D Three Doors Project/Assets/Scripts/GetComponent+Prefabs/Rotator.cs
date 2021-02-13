using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed;

    private float storedRotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        storedRotationSpeed = rotationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    public void StartStopRotation()
    {
        if (rotationSpeed == 0)
        {
            rotationSpeed = storedRotationSpeed;
        }
        else
        {
            storedRotationSpeed = rotationSpeed;
            rotationSpeed = 0;
        }
    }
}
