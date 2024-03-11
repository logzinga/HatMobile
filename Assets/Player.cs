using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float PlayersMovementSpeed;
    private float _playersMovementDirection = 0;
    private Controls _inputActionReference;
    private Rigidbody2D _playersRigidBody;

    private void Start() {
        _playersRigidBody ??= GetComponent<Rigidbody2D>();

        _inputActionReference = new Controls();
        _inputActionReference.Enable();

        _inputActionReference.Ground.Move.performed += moving => {
            _playersMovementDirection = moving.ReadValue<float>();
        };
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
            _playersRigidBody.velocity = new Vector2(_playersMovementDirection * PlayersMovementSpeed, _playersRigidBody.velocity.y);
    }
}
