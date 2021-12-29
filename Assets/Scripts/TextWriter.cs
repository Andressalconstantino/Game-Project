using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
    private Text uiText;
    private string textToWrite;
    private int charIndex;
    private float timePerChar;
    private float timer;
    private bool invisibleCharacters;

    public void AddWriter(Text uiText, string textToWrite, float timePerChar, bool invisibleCharacters){
        this.uiText = uiText;
        this.textToWrite = textToWrite;
        this.timePerChar = timePerChar;
        this.invisibleCharacters = invisibleCharacters;
        charIndex = 0;
    }

    public void Update(){
        if (uiText != null){
            timer -= Time.deltaTime;
            while (timer <= 0f){
                //Display next character
                timer += timePerChar;
                charIndex++;
                string text = textToWrite.Substring(0, charIndex);
                if (invisibleCharacters){
                    text += "<color=#00000000>" + textToWrite.Substring(charIndex) + "</color>" ;
                }
                uiText.text = text;

                if (charIndex >= textToWrite.Length){
                    //entire string displayer
                    uiText = null;
                    return;
                }

            }
        }
    }
}
