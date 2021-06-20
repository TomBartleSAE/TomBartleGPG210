using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Soccer
{
    public class Goal : MonoBehaviour
    {
        public event Action<Team> OnGoal;
        
        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball"))
            {
                if (OnGoal != null)
                {
                    OnGoal(GetComponent<Team>());
                }
            }
        }
    }
}

