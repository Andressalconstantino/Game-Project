using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlueLight2 : MonoBehaviour
{
    Collider2D crystal2;
    public Renderer blueLight21;
    public Renderer blueLight22;
    public Collider2D player;
    private bool nottouching;
    // Start is called before the first frame update
    void Start()
    {
        crystal2 = GetComponent<Collider2D>();
        blueLight21.enabled = false;
        blueLight22.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.IsTouching(crystal2)){
            nottouching = true;
        }

        if (player.IsTouching(crystal2) && !blueLight21.enabled  && nottouching){
            blueLight21.enabled = true;
            blueLight22.enabled = true;
            nottouching = false;
        }

        else if (player.IsTouching(crystal2) && blueLight21.enabled  && nottouching){
            blueLight21.enabled = false;
            blueLight22.enabled = false;
            nottouching = false;
        }
    }
}
