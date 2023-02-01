using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyControls : MonoBehaviour
{
    public GameObject[] bodyPartSelection;

    private GameObject currentBodyPart;

    private int index =0;


    // Start is called before the first frame update
    void Start()
    {
        currentBodyPart = bodyPartSelection[index];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index++;
            if (index >= 6)
            {
                index = 0;
            }
            currentBodyPart = bodyPartSelection[index];
            Debug.Log(currentBodyPart.tag);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index--;
            if (index <= -1)
            {
                index = 5;
            }
            currentBodyPart = bodyPartSelection[index];
            Debug.Log(currentBodyPart.tag);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentBodyPart.tag == "WordHead")
            {
                GameObject.FindWithTag("EmptyHead").GetComponent<BodyChanger>().NextOption();
            }
            else if (currentBodyPart.tag == "WordTorso")
            {
                GameObject.FindWithTag("EmptyTorso").GetComponent<BodyChanger>().NextOption();
            }
            else if (currentBodyPart.tag == "WordLeftArm")
            {
                GameObject.FindWithTag("EmptyLeftArm").GetComponent<BodyChanger>().NextOption();
            }
            else if (currentBodyPart.tag == "WordRightArm")
            {
                GameObject.FindWithTag("EmptyRightArm").GetComponent<BodyChanger>().NextOption();
            }
            else if (currentBodyPart.tag == "WordLeftLeg")
            {
                GameObject.FindWithTag("EmptyLeftLeg").GetComponent<BodyChanger>().NextOption();
            }
            else if (currentBodyPart.tag == "WordRightLeg")
            {
                GameObject.FindWithTag("EmptyRightLeg").GetComponent<BodyChanger>().NextOption();
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentBodyPart.tag == "WordHead")
            {
                GameObject.FindWithTag("EmptyHead").GetComponent<BodyChanger>().PreviousOption();
            }
            else if(currentBodyPart.tag == "WordTorso")
            {
                GameObject.FindWithTag("EmptyTorso").GetComponent<BodyChanger>().PreviousOption();
            }
            else if (currentBodyPart.tag == "WordLeftArm")
            {
                GameObject.FindWithTag("EmptyLeftArm").GetComponent<BodyChanger>().PreviousOption();
            }
            else if (currentBodyPart.tag == "WordRightArm")
            {
                GameObject.FindWithTag("EmptyRightArm").GetComponent<BodyChanger>().PreviousOption();
            }
            else if (currentBodyPart.tag == "WordLeftLeg")
            {
                GameObject.FindWithTag("EmptyLeftLeg").GetComponent<BodyChanger>().PreviousOption();
            }
            else if (currentBodyPart.tag == "WordRightLeg")
            {
                GameObject.FindWithTag("EmptyRightLeg").GetComponent<BodyChanger>().PreviousOption();
            }
        }
                
     /*   if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.FindWithTag("RandomiseButton").RandomisedBodyParts();

        } */ 
    }

   
}

