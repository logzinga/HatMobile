using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointyKill : MonoBehaviour
{
    public Rigidbody2D rb;

    void onCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Player") {
            // todo
        }
    }
}
