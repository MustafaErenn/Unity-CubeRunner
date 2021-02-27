using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public GameObject player;


    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            player.GetComponent<PlayerController>().isGrounded = true;
            //Debug.Log("true olmalı hocam true");
        }
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            player.GetComponent<PlayerController>().isGrounded = false;
        }
    }
}
