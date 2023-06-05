using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CheckBeachCollider : MonoBehaviour
{
    //Add Audio snapshots for certain area's
    public AudioMixerSnapshot forest;
    public AudioMixerSnapshot inCampfire;
    public AudioMixerSnapshot inBeach;
 


    public float beach_TransitionIn  = 1f;
    public float beach_TransitionOut = 1f;

    public float campfire_TransitionIn  = 1f;
    public float campfire_TransitionOut = 1f;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Check if in Certain Zone and change the current audio snapshot
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("BeachZone") && collider)
        {
         inBeach.TransitionTo(beach_TransitionIn);
        }

        else if (collider.CompareTag("CampfireZone") && collider)
        {
         inCampfire.TransitionTo(campfire_TransitionIn);
        }
    }

    // Check if NOT in Certain Zone and change the current audio snapshot back
     void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("BeachZone") && collider)
        {
         forest.TransitionTo(beach_TransitionOut);
        }
        else if (collider.CompareTag("CampfireZone") && collider)
        {
         forest.TransitionTo(campfire_TransitionOut);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



// void OnTriggerEnter(Collider beach)
//     {
//         if (beach.CompareTag("BeachZone") && beach)
//         {
//          inBeach.TransitionTo(beach_TransitionIn);
//         }
//     }

//      void OnTriggerExit(Collider beach)
//     {
//         if (beach.CompareTag("BeachZone") && beach)
//         {
//          forest.TransitionTo(beach_TransitionOut);
//         }
//     }