using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables
    public GameObject player;
    //public Transform cameraPosition;
    private Vector3 offset;
    //private Vector3 offset = new Vector3(1,1.6f,-0.8f);
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset camera behind player position
        transform.position = player.transform.position + offset;
    }
}
