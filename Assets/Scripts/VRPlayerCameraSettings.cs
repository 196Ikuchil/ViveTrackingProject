using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayerCameraSettings : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    //float mrFieldOfView = 31.2f;
    float mrFieldOfView = 16f;
    // Use this for initialization
    void Start ()
    {

        switch ( GlobalSettings.Instance.cameraType )
        {
            case CameraType.SIMPLE:
                break;
            case CameraType.VR:
            case CameraType.VRTrack:
                camera.stereoSeparation = 50;
                break;
            case CameraType.MR:
                camera.clearFlags = CameraClearFlags.SolidColor;
                camera.backgroundColor = Color.black;
                camera.fieldOfView = mrFieldOfView;
                break;
        }

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
