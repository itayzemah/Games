using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private Animator anim;
    private AudioSource doorOpenSound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        doorOpenSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("IsDoorOpen", true);
        doorOpenSound.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("IsDoorOpen", false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
