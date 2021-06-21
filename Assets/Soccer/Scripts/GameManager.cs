using System;
using System.Collections;
using UnityEngine;

namespace Soccer
{
    public class GameManager : MonoBehaviour
    {
        public event Action OnReset;
        
        public void StartCountdown(Team team)
        {
            StartCoroutine(ResetGame());
        }
        
        public IEnumerator ResetGame()
        {
            yield return new WaitForSeconds(5f);

            if (OnReset != null)
            {
                OnReset(); 
            }
        }
        
        private void OnEnable()
        {
            foreach (Goal goal in FindObjectsOfType<Goal>())
            {
                goal.OnGoal += StartCountdown;
            }
        }
    }
}
