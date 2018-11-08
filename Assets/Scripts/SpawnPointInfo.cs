using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointInfo : MonoBehaviour {
    public int SpawnPointID;
    private PlayerController player;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();

        if(player.getSpawnID() == SpawnPointID)
        {
            player.transform.position = transform.position;
        }
    }
}
