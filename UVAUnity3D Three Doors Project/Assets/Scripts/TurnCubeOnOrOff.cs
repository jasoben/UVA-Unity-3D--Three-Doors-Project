using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCubeOnOrOff : MonoBehaviour
{
    public Material onMaterial, offMaterial;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material = onMaterial;
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().material = offMaterial;
    }
}
