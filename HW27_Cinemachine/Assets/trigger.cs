using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class trigger : MonoBehaviour
{
   [SerializeField] private PlayableDirector timeline2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Start0");
            timeline2.Play();
        }
    }
}
