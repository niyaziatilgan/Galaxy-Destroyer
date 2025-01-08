using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] string[] timelineText;
    [SerializeField] TMP_Text dialogueText;

    int curentLine = 0;

    public void NextDialogueLine()
    {
        curentLine++;
        dialogueText.text = timelineText[curentLine];
    }
}
