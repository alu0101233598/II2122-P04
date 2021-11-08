using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebcamController : MonoBehaviour
{

    private Renderer render;

    void Awake() 
    {
        render = GetComponent<Renderer>();
    }

    void Start()
    {
        WebCamTexture webcam = new WebCamTexture();
        render.material.mainTexture = webcam;
        webcam.Play();
    }
}
