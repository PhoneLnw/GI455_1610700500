using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeFind : MonoBehaviour
{
    public string Ant, Bat, Cat, Dog, Rat;
    public Text inputField;
    public Text textDisplay;

    public void resultName()
    {
        if (inputField.text == "Ant")
        {
            Ant = inputField.GetComponent<Text>().text;
            textDisplay.GetComponent<Text>().text = "Ant is found.";
        }
        else if (inputField.text == "Bat")
        {
            Bat = inputField.GetComponent<Text>().text;
            textDisplay.GetComponent<Text>().text = "Bat is found.";
        }
        else if (inputField.text == "Cat")
        {
            Cat = inputField.GetComponent<Text>().text;
            textDisplay.GetComponent<Text>().text = "Cat is found.";
        }
        else if (inputField.text == "Dog")
        {
            Dog = inputField.GetComponent<Text>().text;
            textDisplay.GetComponent<Text>().text = "Dog is found.";
        }
        else if (inputField.text == "Rat")
        {
            Rat = inputField.GetComponent<Text>().text;
            textDisplay.GetComponent<Text>().text = "Rat is found.";
        }
        else
        {
            textDisplay.GetComponent<Text>().text =  inputField.text + " is not found. ";
        }
    }







}
