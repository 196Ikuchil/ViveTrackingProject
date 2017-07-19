using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using IkLibrary.Unity;
public enum PlayerType
{
    HOST,
    CLIENT
}

public enum CameraType
{
    SIMPLE,
    VR,
    VRTrack,
    MR
}


public class GlobalSettings : SingletonMonoBehaviour<GlobalSettings>
{
    [SerializeField]
    public PlayerType playerType;// { get; private set; }
    [SerializeField]
    public CameraType cameraType = CameraType.SIMPLE;

    void Awake ()
    {
        switch ( cameraType )
        {
            case ( CameraType.SIMPLE ):
                VRSettings.enabled = false;
                break;
            case ( CameraType.VR ):
                VRSettings.enabled = true;
                break;
            case ( CameraType.VRTrack ):
                VRSettings.enabled = true;
                break;
            case ( CameraType.MR ):
                VRSettings.enabled = true;
                break;

        }

    }
    // Use this for initialization
    void Start ()
    {
        //着席モード
        //VRDevice.SetTrackingSpaceType (TrackingSpaceType.Stationary);
        //位置トラッキングのリセット(着席モードのみ)
        //InputTracking.Recenter ();
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
