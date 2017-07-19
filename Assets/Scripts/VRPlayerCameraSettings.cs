using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayerCameraSettings : MonoBehaviour
{

    Camera camera;
    // Use this for initialization
    void Start ()
    {
        if ( GlobalSettings.Instance.cameraType == CameraType.MR )
        {
            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = Color.black;
        }

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
