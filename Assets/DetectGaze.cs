using UnityEngine;
using System.Collections;
using System;

public class DetectGaze : MonoBehaviour, IGvrGazeResponder
{
    public void OnGazeEnter()
    {
        Debug.Log("Gaze Entered!!!");
    }

    public void OnGazeExit()
    {

    }

    public void OnGazeTrigger()
    {

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
