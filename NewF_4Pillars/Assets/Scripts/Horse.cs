using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal  //Example of inheritance
{
    [SerializeField] private AudioSource NeighCall;
    private Rigidbody rb;
    private string m_displayName; //backing field

    public string DisplayName //Example of encapsulation
    
    { 
        get { return m_displayName; }

        set
        {
            if(value.Length > 10)
            {
                Debug.LogError("Name can't be longer than ten chars.");
            }
            else
            {
                m_displayName = value;
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        DisplayName = "Horse";
        Debug.Log(DisplayName);
        MakeSound(); 
        
    }

    public void PlaySound()
    {
        NeighCall.Play();
    }

    public override void MakeSound() //Example of polymorphism
    {
        Debug.Log("Horse made a neeeeigh!");
    }

    public override void Jump() //ABSTRACTION
    {
        rb.AddForce(Vector3.up * 500);
    }
}
