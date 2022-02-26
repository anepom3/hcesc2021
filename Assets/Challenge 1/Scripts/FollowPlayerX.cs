using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // Variables
    private GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.Find("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset Camera to the side of the plane
        transform.position = plane.transform.position + offset;
    }
}
