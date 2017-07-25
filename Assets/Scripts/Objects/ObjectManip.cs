using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Objects
{
    public class ObjectManip : MonoBehaviour
    {
#if UNITY_STANDALONE_WIN

        SteamVR_Controller.Device device;
        public GameObject manipObj;
        bool manipulating = false;
        // Use this for initialization
        void Start ()
        {
            var trackedobj = GetComponent<SteamVR_TrackedObject> ();
            device = SteamVR_Controller.Input (( int ) trackedobj.index);
        }

        // Update is called once per frame
        void Update ()
        {

            if ( device.GetPressDown (SteamVR_Controller.ButtonMask.Trigger) )
            {
                if ( manipObj != null )
                {
                    manipulating = true;
                }
            }
            //操作中
            if ( manipulating && device.GetPress (SteamVR_Controller.ButtonMask.Trigger) )
            {
                //manipObjを新たなスクリプトに変更しておいて、
                //そこのclientメソッドに変更を送信

            }
            if ( device.GetPressUp (SteamVR_Controller.ButtonMask.Trigger) )
            {
                manipulating = false;
            }



        }
#endif
    }
}