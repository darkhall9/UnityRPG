using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Locations", menuName = "Spawn Points")]
public class SpawnLocations : ScriptableObject{
    public string[] spawnNames;
    public Vector2[] spawnLocations;

    public Dictionary<string, Vector2> nameAndSpawnDictionary()
    {
        Dictionary<string, Vector2> keyValuePairs = new Dictionary<string, Vector2>();
        for(var i = 0; i <  spawnNames.Length; i++)
        {
            keyValuePairs.Add(spawnNames[i], spawnLocations[i]);
        }

        return keyValuePairs;
    }
}
