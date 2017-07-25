using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.VR;

public class PersonBackground : NetworkBehaviour
{

    [SerializeField]
    GameObject background;
    // Use this for initialization
    void Start ()
    {
        if ( hasAuthority )
            if ( !( GlobalSettings.Instance.cameraType == CameraType.VR || GlobalSettings.Instance.cameraType == CameraType.VRTrack ) )
                Destroy (background.gameObject);
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
