using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    public float moveSpeed = -0.1f;
    public AudioClip collisionSound;
    public AudioSource audioSource;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal");
        movement = CrossPlatformInputManager.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<AudioManager>().Play("Punch");
        LivesScript.life -= 1;
       // SceneManager.LoadScene("Main Menu");
        //Spawner.score = 0;
    }

    internal static void DestroyObject()
    {
        throw new NotImplementedException();
    }
}


