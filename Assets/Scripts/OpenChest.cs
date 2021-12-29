using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{

    Renderer lockedChest;
    public Collider2D player;
    public Collider2D ulChest;
    public Renderer unlockedChest;
    public Renderer BlueLight1;
    public Renderer BlueLight2;
    public Renderer BlueLight3;
    public Renderer BlueLight4;
    public Renderer BlueLight5;
    private bool canTouch;

    // Start is called before the first frame update
    void Start()
    {
        lockedChest = GetComponent<Renderer>();
        canTouch = false;
    }

    // Update is called once per frame
    void Update()
    {
    
        if(!BlueLight1.enabled && BlueLight2.enabled && !BlueLight3.enabled && BlueLight4.enabled && BlueLight5.enabled){
            lockedChest.enabled = false;
            unlockedChest.enabled = true;
            canTouch = true;
        }
        else{
            lockedChest.enabled = true;
            unlockedChest.enabled = false;
            canTouch = false;
        }
        if (canTouch && player.IsTouching(ulChest)){
            lockedChest.enabled = true;
        }
    }
}
