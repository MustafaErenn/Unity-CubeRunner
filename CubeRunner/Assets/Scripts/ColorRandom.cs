using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandom : MonoBehaviour
{
    public Camera mainCamera;
    Color randomColor;
    Color notRandomColor;
    public Camera Level1Camera;

    public void Awake()
    {
        Level1Camera = GetComponent<Camera>();
        Level1Camera = GameObject.FindObjectOfType<Camera>();
        Level1Camera.backgroundColor = new Color(255, 0, 0);
    }

    void Start()
    {

        /*Level1Camera = GameObject.Find("Main Camera");
        Level1Camera.GetComponent<Camera>();*/

        Level1Camera = GetComponent<Camera>();
        Level1Camera = GameObject.FindObjectOfType<Camera>();
        Level1Camera.backgroundColor = new Color(255, 0, 0);


        /*mainCamera = GetComponent<Camera>();
        mainCamera = GameObject.FindObjectOfType<Camera>();

        randomColor = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255),255);
        notRandomColor = new Color(120, 180, 255,255);*/


        

    }

    // Update is called once per frame
    void Update()
    {
        //mainCamera.backgroundColor = notRandomColor;
        //RenderSettings.skybox.SetColor("randomColor", randomColor);
    }
}
