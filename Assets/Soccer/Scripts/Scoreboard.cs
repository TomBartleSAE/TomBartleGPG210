using System;
using TMPro;
using UnityEngine;

namespace Soccer
{
    public class Scoreboard : MonoBehaviour
    {
        private int score;

        // Subscribe to all goal events
        private void OnEnable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal += AddScore;
            }
        }
        
        // Unsubscribe to all goal events
        private void OnDisable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal -= AddScore;
            }
        }
        
        // Increase score and update scoreboard if my team scores
        private void AddScore(Team team)
        {
            if (team.myTeam == GetComponent<Team>().myTeam)
            {
                score++;
                GetComponent<TextMeshPro>().text = score.ToString();
            }
        }
    }
}
