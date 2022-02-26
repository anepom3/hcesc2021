using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset camera behind player position
        transform.position = player.transform.position + offset;
    }
}
