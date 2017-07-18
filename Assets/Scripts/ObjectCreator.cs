using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField]
    NetworkManager netManager;

    [SerializeField]
    public GameObject RoomPrefab;

    public void SpawnObject ( GameObject obj )
    {
        var o = Instantiate (obj);
        NetworkServer.Spawn (o);
    }

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
