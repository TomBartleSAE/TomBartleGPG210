using System;
using UnityEngine;

namespace Soccer
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody rb;
        public float speed = 5f;
        
        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
        }
    }
}
