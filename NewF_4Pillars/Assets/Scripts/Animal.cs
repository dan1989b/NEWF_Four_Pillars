using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private AudioSource Growl;
    private Rigidbody rb;
   
   
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void PlayOrigSound()
    {
        Growl.Play();
    }

    public virtual void Jump()
    {
        rb.AddForce(Vector3.up * 150);
        Debug.Log("Jumped 1 foot");
    }

    public virtual void MakeSound()
    {
        Debug.Log("Made a basic animal sound.");
    }
}
