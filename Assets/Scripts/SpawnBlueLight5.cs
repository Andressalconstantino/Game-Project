using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlueLight5 : MonoBehaviour
{
    Collider2D crystal5;
    public Renderer blueLight51;
    public Renderer blueLight52;
    public Collider2D player;
    private bool nottouching;
    // Start is called before the first frame update
    void Start()
    {
        crystal5 = GetComponent<Collider2D>();
        blueLight51.enabled = false;
        blueLight52.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.IsTouching(crystal5)){
            nottouching = true;
        }

        if (player.IsTouching(crystal5) && !blueLight51.enabled  && nottouching){
            blueLight51.enabled = true;
            blueLight52.enabled = true;
            nottouching = false;
        }

        else if (player.IsTouching(crystal5) && blueLight51.enabled  && nottouching){
            blueLight51.enabled = false;
            blueLight52.enabled = false;
            nottouching = false;
        }
    }
}
