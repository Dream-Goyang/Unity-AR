using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetScript : MonoBehaviour
{
    Text text;
    GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Track_Cat1()
    {
        var eventHandlerComponent : DefaultTrackableEventHandler = imageTarget.GetComponent(DefaultTrackableEventHandler);
        var mTrackableBehaviour = GetComponent<TrackableBehaviour>();

    }

    public void Track_Cat2()
    {

    }
}
