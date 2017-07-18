using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.Networking;

namespace Device
{

    public class HandTracker : MonoBehaviour
    {
        [SerializeField]
        VRNode hand;

        // Use this for initialization
        void Start ()
        {
            if ( GlobalSettings.Instance.cameraType == CameraType.SIMPLE || GlobalSettings.Instance.cameraType == CameraType.MR )
                NetworkServer.Destroy (this.gameObject);
        }

        // Update is called once per frame
        void Update ()
        {
            var hand = InputTracking.GetLocalPosition (this.hand);
            //s.y *= -1f;
            transform.localPosition = hand;

            transform.rotation = InputTracking.GetLocalRotation (this.hand);
        }
    }
}