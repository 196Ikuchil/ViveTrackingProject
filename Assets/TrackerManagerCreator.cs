using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TrackerManagerCreator :NetworkBehaviour {

	[SerializeField]
	GameObject TrackerManagerPref;
	// Use this for initialization
	[ClientCallback]
	void Start () {
		if (GlobalSettings.Instance.cameraType == CameraType.VRTrack) 
		{
			CmdInstasntiateTrackerManager (this.gameObject);
		}

	}
	[Command]
	void CmdInstasntiateTrackerManager(GameObject obj){
		NetworkServer.SpawnWithClientAuthority (Instantiate (TrackerManagerPref), obj);
	}
}
