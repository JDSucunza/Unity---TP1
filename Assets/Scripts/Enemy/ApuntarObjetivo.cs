﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntarObjetivo : MonoBehaviour
{
    
    
    public Transform player;
    
    // Start is called before the first frame update
    


    // Update is called once per frame
    void Update()
    {
       transform.LookAt(player);
       
    }

   
 

} 
