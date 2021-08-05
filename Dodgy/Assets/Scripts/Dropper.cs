using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rbody;
    [SerializeField] float timeToWait = 5f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rbody.useGravity = true;
        }
    }
}
