using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {


    Material cubeMat;
    public Color goodCubeColor, badCubeColor, defaultCubeColor; 


    //This function says: "if you enter another object's trigger, look at that thing's collider component, and store it in the "thingTriggered" variable
    private void OnTriggerEnter(Collider thingTriggered)
    {
        cubeMat = thingTriggered.gameObject.GetComponent<Renderer>().material;
     
        if (thingTriggered.gameObject.CompareTag("good"))
        {
            cubeMat.color = goodCubeColor;

        }
        else
        {
            cubeMat.color = badCubeColor; 
        }
    }

    //This function runs when you leave a trigger, and it stores that thing in "thingExited"
    private void OnTriggerExit(Collider thingExited)
    {
        thingExited.GetComponent<Renderer>().material.color = defaultCubeColor; 
    }

    
}
