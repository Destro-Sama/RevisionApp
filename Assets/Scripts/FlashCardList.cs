using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashCardList : MonoBehaviour
{
    public List<string> Front = new List<string>();
    public List<string> Back = new List<string>();

    private void Start()
    {
        Front.Add("The mitochondria is the {x} of the cell");
        Back.Add("Mitochondria");

        Front.Add("Hello");
        Back.Add("Bye");
    }
}
