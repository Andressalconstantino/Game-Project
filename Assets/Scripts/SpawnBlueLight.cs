using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlueLight : MonoBehaviour
{
    Collider2D crystal1;
    public Renderer blueLight11;
    public Renderer blueLight12;
    public Collider2D player;
    private bool nottouching;
    // Start is called before the first frame update
    void Start()
    {
        crystal1 = GetComponent<Collider2D>();
        blueLight11.enabled = false;
        blueLight12.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.IsTouching(crystal1)){
            nottouching = true;
        }

        if (player.IsTouching(crystal1) && !blueLight11.enabled && nottouching){
            blueLight11.enabled = true;
            blueLight12.enabled = true;
            nottouching = false;
        }

        else if (player.IsTouching(crystal1) && blueLight11.enabled && nottouching){
            blueLight11.enabled = false;
            blueLight12.enabled = false;
            nottouching = false;
        }
    }
}
