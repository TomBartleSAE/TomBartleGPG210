using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Soccer
{
    public class Spectator : MonoBehaviour
    {
        private void OnEnable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal += Cheer;
            }
        }

        public void Cheer(Team team)
        {
            if (team.myTeam == GetComponent<Team>().myTeam)
            {
                print("Go " + GetComponent<Team>().myTeam.ToString() + " team!");
            }
        }
    }
}

