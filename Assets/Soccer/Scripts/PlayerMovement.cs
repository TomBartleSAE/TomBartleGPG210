using System;
using UnityEngine;

namespace Soccer
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody rb;
        public float speed = 5f;

        private float horizontal, vertical;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
        }
    }
}
