using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal //Example of inheritance
{
    [SerializeField] private AudioSource BockCall;
    private string m_displayName;
    //Backing field
    

   
    public string DisplayName  //Example of encapsulation
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
        DisplayName = "Chicken";
        Debug.Log(DisplayName);
    }

    public void PlaySound()
    {
        BockCall.Play();
    }

    public override void MakeSound()  //Example of polymorphism
    {
        Debug.Log("Chicken bocked!");
    }

    public override void Jump()
    {
        Debug.Log("Chicken jumped 3 feet!");
    }
}

