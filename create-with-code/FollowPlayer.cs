using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame, after Update()
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to player's position
        this.transform.position = player.transform.position + this.offset;
    }
}
