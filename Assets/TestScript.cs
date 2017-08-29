using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Experiment;
public class TestScript : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {
        DataWriter.Instance.InitializeFile ();
        DataWriter.Instance.WriteWord ("Hello");
        DataWriter.Instance.CloseFile ();

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
