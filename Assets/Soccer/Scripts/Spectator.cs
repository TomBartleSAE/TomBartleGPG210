using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Soccer
{
    public class Spectator : MonoBehaviour
    {
        // Subscribes to all goal events
        private void OnEnable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal += Cheer;
            }
        }
        
        // Unsubscribes to all goal events
        private void OnDisable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal -= Cheer;
            }
        }
        
        // Cheers for their own team when they score
        public void Cheer(Team team)
        {
            if (team.myTeam == GetComponent<Team>().myTeam) // Checks if my team scored
            {
                print("Go " + GetComponent<Team>().myTeam.ToString() + " team!");
            }
        }
    }
}

