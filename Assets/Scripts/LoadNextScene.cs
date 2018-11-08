﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {
    public int correspondingSpawnID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")   //If the object entering the trigger is the Player, execute statement.
        {
            collision.gameObject.GetComponent<PlayerController>().setSpawnID(correspondingSpawnID);
            SceneManager.LoadScene(name);   //Loads the scene based on the trigger's name.
        }
    }
}
