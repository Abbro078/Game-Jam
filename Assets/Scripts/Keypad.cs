using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject buttonClear;
    public GameObject buttonEnter;

    public void b1()
    {
        inputField.text = inputField.text + "1";
    }
    public void b2()
    {
        inputField.text = inputField.text + "2";
    }
    public void b3()
    {
        inputField.text = inputField.text + "3";
    }
    public void b4()
    {
        inputField.text = inputField.text + "4";
    }
    public void b5()
    {
        inputField.text = inputField.text + "5";
    }
    public void b6()
    {
        inputField.text = inputField.text + "6";
    }
    public void b7()
    {
        inputField.text = inputField.text + "7";
    }
    public void b8()
    {
        inputField.text = inputField.text + "8";
    }
    public void b9()
    {
        inputField.text = inputField.text + "9";
    }
    public void bClear()
    {
        inputField.text = null;
    }

    public void bEnter()
    {
        if(inputField.text == "3977")
        {
            Debug.Log("opened");
        }
        else
        {
            bClear();
            Debug.Log("wrong");
        }
    }
}
