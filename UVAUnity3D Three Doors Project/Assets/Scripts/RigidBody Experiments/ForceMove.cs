using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMove : MonoBehaviour
{
    Rigidbody rigidbody;

    public Vector3 forceOnBall;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody.AddForce(forceOnBall);

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddRelativeForce(forceOnBall);
        }
    }
}
