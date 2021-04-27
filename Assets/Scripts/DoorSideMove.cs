using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSideMove : MonoBehaviour
{
    private Animator anim;
    public AudioSource doorOpenSound;
    public AudioSource doorCloseSound;
// Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        doorOpenSound = GetComponent<AudioSource>();
        doorCloseSound = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("IsDoorOpen", true);
        doorOpenSound.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("IsDoorOpen", false);
        doorCloseSound.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
