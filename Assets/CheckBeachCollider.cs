using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CheckBeachCollider : MonoBehaviour
{

    public AudioMixerSnapshot inBeach;
    public AudioMixerSnapshot outBeach;

    private float b_TransitionIn;
    private float b_TransitionOut;

    // Start is called before the first frame update
    void Start()
    {
        b_TransitionIn = 1.5f;
        b_TransitionOut = 2.5f;
    }

    void OnTriggerEnter(Collider beach)
    {
        if (beach.CompareTag("BeachZone") && beach)
        {
         inBeach.TransitionTo(b_TransitionIn);
        }
    }

     void OnTriggerExit(Collider beach)
    {
        if (beach.CompareTag("BeachZone") && beach)
        {
         outBeach.TransitionTo(b_TransitionOut);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



