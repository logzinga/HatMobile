using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointyKill : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameManager gm;

    public Vector2 downSpeed;

    void OnCollisionEnter2D (Collision2D collision2D) {
        if (collision2D.collider.tag == "Player") {
            print("Player Hit!");
            gm.EndGame();
        }
        if (collision2D.collider.tag == "Ground") {
            print("Ground Hit!");
            Destroy(gameObject);
        }
    }

    void FixedUpdate() {
        //rb.AddForce(downSpeed * Time.fixedDeltaTime);
    }
}
