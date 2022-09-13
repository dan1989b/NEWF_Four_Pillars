using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
