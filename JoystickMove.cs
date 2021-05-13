using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour {
    private Rigidbody2D rb;
    private float dirX, dirY;
    public float moveSpeed;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;
    }
    private void FixedUpdate() {
        rb.velocity = new Vector2(dirX, dirY);
    }
}
