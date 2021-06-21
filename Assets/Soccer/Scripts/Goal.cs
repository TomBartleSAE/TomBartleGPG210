using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Soccer
{
    public class Goal : MonoBehaviour
    {
        public event Action<Team> OnGoal;
        
        // Triggers goal event when ball touches collider
        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball"))
            {
                if (OnGoal != null)
                {
                    OnGoal(GetComponent<Team>()); // Goal has a team component which tells listening objects which team scored
                }
            }
        }
    }
}