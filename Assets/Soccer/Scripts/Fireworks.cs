using System;
using UnityEngine;

namespace Soccer
{
    public class Fireworks : MonoBehaviour
    {
        // Subscribe to all goal events
        private void OnEnable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal += SpawnFireworks;
            }
        }
        
        // Unsubscribe to all goal events
        private void OnDisable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal -= SpawnFireworks;
            }
        }

        public void SpawnFireworks(Team team)
        {
            if (team.myTeam == GetComponent<Team>().myTeam)
            {
                GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
