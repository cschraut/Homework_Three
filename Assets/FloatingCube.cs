using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCube : MonoBehaviour
{
    MeshRenderer meshRenderer;
    new Rigidbody rigidbody;

    [SerializeField] float timeToWait = 10f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
