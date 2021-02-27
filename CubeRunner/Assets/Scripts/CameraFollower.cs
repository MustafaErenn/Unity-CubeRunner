using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public Vector3 offset;
    private float followDistance;
    

    void Start()
    {
        player = GameObject.Find("Player");
        mainCamera = GameObject.Find("Main Camera");
        offset = new Vector3(0f,3f,-8f);
        mainCamera.transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
         
          mainCamera.transform.position = new Vector3((mainCamera.transform.position.x), mainCamera.transform.position.y, player.transform.position.z + offset.z);
        if(player.transform.position.x<-3.5f)
        {
            mainCamera.transform.position = new Vector3((-2.5f), mainCamera.transform.position.y, player.transform.position.z + offset.z);

        }
        else if(player.transform.position.x>-0.5f && player.transform.position.x<0.5f)
        {
            mainCamera.transform.position = new Vector3((0f), mainCamera.transform.position.y, player.transform.position.z + offset.z);
        }
        else if(player.transform.position.x>3.5f)
        {
          
            mainCamera.transform.position = new Vector3((2.5f), mainCamera.transform.position.y, player.transform.position.z + offset.z);
        }
    }
    
}
