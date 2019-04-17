using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Goal goal;
    public GameObject spawn;
    public GameObject gilleSpawn;
    public Movement player;
    public GilleLeMonstre monster;
    private AudioSource music;

    public float timeMultiplier = 1.5f;
    public float musicPitchMultiplier = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (goal.isColliding()) {
            Time.timeScale *= timeMultiplier;
            music.pitch *= musicPitchMultiplier;
            player.reset(spawn.transform.position);
            monster.reset(gilleSpawn.transform.position);
        }
    }
}
