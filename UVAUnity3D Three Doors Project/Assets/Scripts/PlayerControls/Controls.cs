using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // This will allow us to control this object

    public KeyCode forward, backward, right, left;
    public float moveSpeed;

    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(forward))
        {
            rigidbody.MovePosition(rigidbody.position + new Vector3(0, 0, moveSpeed));
        }
        if (Input.GetKey(backward))
        {
            rigidbody.MovePosition(rigidbody.position + new Vector3(0, 0, -moveSpeed));
        }
        if (Input.GetKey(left))
        {
            rigidbody.MovePosition(rigidbody.position + new Vector3(-moveSpeed,0,0));
        }
        if (Input.GetKey(right))
        {
            rigidbody.MovePosition(rigidbody.position + new Vector3(moveSpeed,0,0));
        }
        
    }

}
