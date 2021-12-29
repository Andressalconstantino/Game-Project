using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{

    [SerializeField] private TextWriter textWriter;

    private Text message;
    public Canvas canvas;
    public Collider2D takeKey;
    public Collider2D needKey;
    public Collider2D player;
    public Collider2D lockedGate;
    public float writingSpeed = 0.1f;
    private bool tookKey;
    private bool touched;
    public Renderer hasKey;
    private void Awake(){
        message = transform.Find("message").Find("Text").GetComponent<Text>();
    }
    private void Start(){
        canvas.enabled = false;
        tookKey = false;
        touched = false;
    }
    private void Update(){
        if (player.IsTouching(takeKey) && !tookKey && !touched){
            //message.text = "There is a key inside the chest. It looks like the one on the map. Im gonna take it.";
            textWriter.AddWriter(message, "There is a key inside the chest. It looks like the one on the map. I'm going to take it.", writingSpeed, true);
            canvas.enabled = true;
            tookKey = true;
            touched = true;
        }
        if (player.IsTouching(needKey) && !tookKey && !touched){
            //message.text = "The chest is locked";
            textWriter.AddWriter(message, "The chest is locked", writingSpeed, true);
            canvas.enabled = true;
            touched = true;
        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)){
            message.text = " ";
            canvas.enabled = false;
            touched = false;
        }
        if(tookKey){
            hasKey.enabled = false;
        }
        if (player.IsTouching(lockedGate) && hasKey && !touched){
           // message.text = "The gate is locked. I need a key.";
           textWriter.AddWriter(message, "The gate is locked. I need a key.", writingSpeed, true);
            canvas.enabled = true;
            touched = true;
        }
    }
}
