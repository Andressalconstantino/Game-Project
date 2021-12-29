using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlueLight3 : MonoBehaviour
{
    Collider2D crystal3;
    public Renderer blueLight31;
    public Renderer blueLight32;
    public Collider2D player;
    private bool nottouching;
    // Start is called before the first frame update
    void Start()
    {
        crystal3 = GetComponent<Collider2D>();
        blueLight31.enabled = false;
        blueLight32.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.IsTouching(crystal3)){
            nottouching = true;
        }


        if (player.IsTouching(crystal3) && !blueLight31.enabled  && nottouching){
            blueLight31.enabled = true;
            blueLight32.enabled = true;
            nottouching = false;
        }

        else if (player.IsTouching(crystal3) && blueLight31.enabled  && nottouching){
            blueLight31.enabled = false;
            blueLight32.enabled = false;
            nottouching = false;
        }
    }
}
