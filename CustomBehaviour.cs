﻿/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;
    private static string message;
     
    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;
        string modelName = "";
        //see if we set any name for specific model
        //if so change the name ofr hte game object
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out modelName))
        {
            this.gameObject.name = modelName;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        //fetch the message from the dropdown UI
        message = DropdownChangeText.m_Message;
        //render the selected model 
        if(message == this.gameObject.name){
                foreach (Renderer r in this.gameObject.GetComponentsInChildren<Renderer>())
                    r.enabled = true;
        }else {
                foreach (Renderer r in this.gameObject.GetComponentsInChildren<Renderer>())
                    r.enabled = false;
            }
        
    }
}