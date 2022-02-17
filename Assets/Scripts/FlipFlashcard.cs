using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlipFlashcard : MonoBehaviour
{
    public TMP_Text Frontside;
    public TMP_Text Backside;

    public void Flip()
    {
        string text = Frontside.text;
        Frontside.text = Backside.text;
        Backside.text = text;
    }
}
