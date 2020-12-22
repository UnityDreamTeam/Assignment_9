using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSound : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] GameObject alien;
    [SerializeField] KeyCode talk;

    // Update is called once per frame
    void Update()
    {
        bool alienAround = CheckAliens();
        if (alienAround && Input.GetKey(talk))
        {
            MakeAlienSound();
        }
    }

    bool CheckAliens()
    {
        if (Vector3.Distance(gameObject.transform.position, alien.transform.position) <= radius)
        {
            return true;
        }
        return false;
    }

    void MakeAlienSound()
    {
        alien.GetComponent<AudioSource>().Play();
    }
}