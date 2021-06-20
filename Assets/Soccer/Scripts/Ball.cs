using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Soccer
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody rb;
        public float speed = 5f;
        
        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0,0) * speed;
        }
    }
}

