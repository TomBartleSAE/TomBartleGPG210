using System;
using UnityEngine;

namespace Soccer
{
    public class Respawnable : MonoBehaviour
    {
        private Vector3 startLocation;

        private void Start()
        {
            startLocation = transform.position;
        }

        public void Respawn()
        {
            transform.position = startLocation;

            if (GetComponent<Rigidbody>())
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        
        private void OnEnable()
        {
            FindObjectOfType<GameManager>().OnReset += Respawn;
        }
    }
}
