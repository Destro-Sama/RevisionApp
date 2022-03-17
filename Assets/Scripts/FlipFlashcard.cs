using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlipFlashcard : MonoBehaviour
{
    public TMP_Text Frontside;
    public TMP_Text Backside;

    public int Index = -1;

    public FlashCardList cards;

    private void Start()
    {
        Next();
    }

    public void Flip()
    {
        string text = Frontside.text;
        Frontside.text = Backside.text;
        Backside.text = text;
    }

    public void Next()
    {
        Index += 1;
        if (Index > (cards.Front.Count - 1))
        {
            Index = 0;
        }
        Frontside.text = cards.Front[Index];
        Backside.text = cards.Back[Index];
    }

    public void Previous()
    {
        Index -= 1;
        if (Index < 0)
        {
            Index = cards.Front.Count;
        }
        Frontside.text = cards.Front[Index];
        Backside.text = cards.Back[Index];
    }
}
