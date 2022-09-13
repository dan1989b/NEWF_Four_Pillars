using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal //Example of inheritance
{
    [SerializeField] private AudioSource BockCall;
    private string m_displayName;
    //Backing field
    private Rigidbody rb;



    public string DisplayName  //ENCAPSULATION
    {
        get { return m_displayName; }
        set 
        {
            if(value.Length > 10)
            {
                Debug.LogError("Name cannot be longer than 10 chars.");
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
        DisplayName = "Chicken";
        Debug.Log(DisplayName);
    }

    public void PlaySound()
    {
        BockCall.Play();
    }

    public override void MakeSound()  //POLYMORPHISM
    {
        Debug.Log("Chicken bocked!");
    }

    public override void Jump() //ABSTRACTION
    {
        rb.AddForce(Vector3.up * 300);
        Debug.Log("Chicken jumped 3 feet!");
    }
}

