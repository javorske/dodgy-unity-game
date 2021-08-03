using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
        {
            hits++;
            Debug.Log("Bumped into things " + hits + " times");
        }
    }
}
