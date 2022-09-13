using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private AudioSource Growl;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayOrigSound()
    {
        Growl.Play();
    }

    public virtual void Jump()
    {
        Debug.Log("Jumped 1 foot");
    }

    public virtual void MakeSound()
    {
        Debug.Log("Made a basic animal sound.");
    }
}
