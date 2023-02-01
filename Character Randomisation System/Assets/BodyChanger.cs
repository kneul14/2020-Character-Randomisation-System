using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyChanger : MonoBehaviour
{
    public SpriteRenderer bodyPart;

    public List<Sprite> options = new List<Sprite>(); //List of the body parts 0-5(6).

    
        
    private int selectedOption = 0;


    public void NextOption() //This is the process used for when all the next buttons are pressed.
    {
        selectedOption++;
        if (selectedOption >= options.Count)
            {
                selectedOption = 0; //This resets it if it's cycled through completley.
            }
        
        bodyPart.sprite = options[selectedOption];
    }

    public void PreviousOption()  //This is the process used for when all the previous buttons are pressed.
    {

        selectedOption--;
        if (selectedOption <= 0)
            {
                selectedOption = options.Count - 1; //This resets it if it's cycled through completley.
            }
        
        bodyPart.sprite = options[selectedOption];

    }

    public void RandomisedBodyParts() //This Randomises the body parts on click.
    {
        selectedOption = Random.Range(0, options.Count - 1);
        bodyPart.sprite = options[selectedOption];
    }

}
