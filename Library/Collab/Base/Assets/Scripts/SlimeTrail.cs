using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeTrail : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private bool _enabled;
    public int guid;
    //public SlimeMovement slime;

    public float lifetime;
    private float timer;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        timer = 0;
        

    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if (timer > lifetime) {
            Destroy();
        }

    }

    private void FixedUpdate() {
        
    }
    
    void Destroy() {
        _enabled = false;
        BulletManager.Despawn(guid);
    }
    private void OnEnable() {
        _enabled = true;
    }

}
