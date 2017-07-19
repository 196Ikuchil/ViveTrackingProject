using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdCameraSettings : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {
        if ( GlobalSettings.Instance.playerType != PlayerType.HOST )
            Destroy (this.gameObject);
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
