using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform player;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x,transform.position.y,transform.position.z), new Vector3(player.position.x,transform.position.y,transform.position.z),3f);
    }
}
