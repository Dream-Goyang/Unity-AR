using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    Text text;

    void Cat_Lost()
    {
        text.text = "고양이를 찾아보자!";
    }

    void Cat_Found()
    {
        text.text = "고양이를 잡아보자!";
    }
}
