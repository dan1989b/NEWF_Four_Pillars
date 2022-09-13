using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //Example of inheritance
{
    [SerializeField] private AudioSource BarkCall;
    private string m_displayName;

    public string DisplayName //Example of encapsulation
    {
        get { return m_displayName; }

        set
        {
            if (value.Length > 10)
            {
                Debug.LogError("Name cannot be longer than 10 chars");
            }
            else 
            { m_displayName = value; }

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DisplayName = "Dog";
        Debug.Log(DisplayName);
        MakeSound();
        Jump();
    }

    public void PlaySound()
    {
        BarkCall.Play();
    }

    public override void MakeSound() //Example of polymorphism
    {
        Debug.Log("Dog barked!!!");
    }

    public override void Jump()
    {
        Debug.Log("Dog jumped 2 feet!");
    }
}
