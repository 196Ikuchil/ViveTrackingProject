using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Objects
{
    public class MovableObject : NetworkBehaviour
    {

        // Use this for initialization
        void Start ()
        {

        }

        [ClientCallback]
        // Update is called once per frame
        void Update ()
        {

        }
        ObjectManip o;
        [Client]
        void OnTriggerEnter ( Collider other )
        {
            if ( ( o = other.GetComponent<ObjectManip> () ) )
            {
#if UNITY_STANDALONE_WIN
                o.manipObj = this.gameObject;
#endif
            }

        }

        [Client]
        void OnTriggerExit ( Collider other )
        {
            if ( ( o = other.GetComponent<ObjectManip> () ) )
            {
#if UNITY_STANDALONE_WIN
                o.manipObj = null;
#endif
            }
        }

        [Client]
        public void MoveObject ( Vector3 pos )
        {
            CmdMoveObject (pos);
        }

        [Command]
        void CmdMoveObject ( Vector3 pos )
        {
            transform.position = pos;
        }
    }
}