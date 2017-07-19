using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IkLibrary.Unity;
using UnityEngine.Networking;

namespace Device
{
    /// <summary>
    /// only host
    /// トラッカーの位置を記憶する
    /// </summary>
    public class ViveTrackerTracking : NetworkBehaviour
    {
        [SyncVar, SerializeField]
        Vector3 pos = Vector3.zero;
        public Vector3 LocalPos
        {
            get
            {

                return pos;
            }
            set
            {
                pos = value;
            }
        }
        [SyncVar]
        public Quaternion rot;
        public Quaternion LocalRot
        {
            get
            {

                return rot;
            }
            set
            {
                rot = value;
            }
        }
        // Use this for initialization
        void Start ()
        {

            //if ( GlobalSettings.Instance.playerType != PlayerType.HOST )
            //  Destroy (this);
        }

        // Update is called once per frame
        void Update ()
        {
            Debug.Log ("pos=" + LocalPos);
        }


    }

}