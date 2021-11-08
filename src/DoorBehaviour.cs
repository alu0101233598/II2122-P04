using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{

    private Animation animation;
    private BoxCollider box;
    private bool isOpen;

    void Awake()
    {
        animation = GetComponent<Animation>();
        box = GetComponent<BoxCollider>();
    }

    void Start()
    {
        MicrophoneController.loudEvent += openDoor;
    }

    void openDoor()
    {
        if (!isOpen) 
        {
            isOpen = true;
            animation.Play("Door_Open");
            box.enabled = false;
            
        } 
        else if (isOpen)
        {
            isOpen = false;
            animation.Play("Door_Close");
            box.enabled = true;
        }
    }
}
