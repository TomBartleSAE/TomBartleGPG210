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

        public void Cheer()
        {
            print("Yay!");
        }
    }
}

