using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockGate : MonoBehaviour
{
    private Collider2D gate;
    private Renderer lockedGate;
    public Renderer unlockedGate;
    public Collider2D player;
    public Renderer hasKey;
    // Start is called before the first frame update
    void Start()
    {
        gate = GetComponent<Collider2D>();
        lockedGate = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasKey && player.IsTouching(gate)){
            lockedGate.enabled = false;
            gate.enabled = false;
            unlockedGate.enabled = true;
        }
    }
}
