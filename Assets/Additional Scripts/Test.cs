using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public SpawnLocations location;
	// Use this for initialization
	void Start () {
		if(location != null && location.spawnLocations != null && location.spawnLocations != null)
        {
            Debug.Log(location.nameAndSpawnDictionary().ContainsKey("scene01"));
            Vector2 vector = Vector2.zero;
            location.nameAndSpawnDictionary().TryGetValue("scene01", out vector);
            Debug.Log(vector);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
