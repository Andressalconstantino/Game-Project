using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageAppear : MonoBehaviour
{
    public Renderer Wizard;
    public Renderer PurpleLight;
    Animator animator;
    Renderer sm;
    public Collider2D player;
    public Collider2D wall;

    void Start()
    
    {
        animator = GetComponent<Animator>();
        sm = GetComponent<Renderer>();
        Wizard.enabled = false;
        PurpleLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.IsTouching(wall)){
            wall.enabled = false;
        animator.SetBool("appear", true);
        Wizard.enabled = true;
        PurpleLight.enabled = true;
        Destroy(sm, (float)0.5);
            
        }
    }
}
