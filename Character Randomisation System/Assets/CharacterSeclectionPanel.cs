using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSeclectionPanel : MonoBehaviour
{
    public List<BodyChanger> bodyChangers = new List<BodyChanger>();

    public void RandomiseCharacter()
    {
        foreach (BodyChanger changer in bodyChangers)
        {
            changer.RandomisedBodyParts();
        }

    }
}
