using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int score = 0;
    [SerializeField] public GameObject background;
    [SerializeField] public TextMeshProUGUI scoreNumber;
    [SerializeField] public Button special;


    void Start()
    {
        
    }


    void Update()
    {
        scoreNumber.text = score.ToString();

        EnabledMoveSpecial();
    }

    private void EnabledMoveSpecial()
    {
        if (score < 10) return;
        ButtonScript buttonScript = FindAnyObjectByType<ButtonScript>();
        if (!buttonScript && !buttonScript.buttonMoveSpecial) return;
        buttonScript.buttonMoveSpecial.SetActive(true);
    }

    public void GainPoints(int value)
    {
        score = score + value;
    }

    public void Special()
    {
        var buttonSpecial = special.GetComponent<Button>();
        if (score >= 10)
        {
            buttonSpecial.interactable = true;
        }
        else
        {
            buttonSpecial.interactable = false;
        }
    }
}
