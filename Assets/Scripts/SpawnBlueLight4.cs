using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlueLight4 : MonoBehaviour
{
    Collider2D crystal4;
    public Renderer blueLight41;
    public Renderer blueLight42;
    public Collider2D player;
    private bool nottouching;
    // Start is called before the first frame update
    void Start()
    {
        crystal4 = GetComponent<Collider2D>();
        blueLight41.enabled = false;
        blueLight42.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.IsTouching(crystal4)){
            nottouching = true;
        }

        if (player.IsTouching(crystal4) && !blueLight41.enabled  && nottouching){
            blueLight41.enabled = true;
            blueLight42.enabled = true;
            nottouching = false;
        }

        else if (player.IsTouching(crystal4) && blueLight41.enabled && nottouching){
            blueLight41.enabled = false;
            blueLight42.enabled = false;
            nottouching = false;
        }
    }
}
