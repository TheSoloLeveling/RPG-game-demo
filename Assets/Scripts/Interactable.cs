﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    //public Transform interactionTransform;

    private bool isFocus = false;
    Transform player;

    private bool hasInteracted = false;
   
    public virtual void Interact ()   // this virtual function its need to be ovridden
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);  //interationTransform.position
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
        
    }

    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused ()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

}
