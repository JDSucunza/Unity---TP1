﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Kamikaze : MonoBehaviour
{
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision c){
       


       if (c.gameObject.CompareTag ("Player")){
            Vida player = c.gameObject.GetComponent <Vida> ();      
            player.dead = true;
            
            Destroy (this.gameObject);
       }
       
    }

}
