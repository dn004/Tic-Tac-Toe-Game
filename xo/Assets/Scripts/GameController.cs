using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameController : MonoBehaviour
{
    public TMP_Text[] buttonList;
    private string playerSide;
    public TMP_Text DisplayText;

    public Button Reset;

    void Awake()
    {
        SetGameControllerReferenceOnButtons();
        playerSide = "X";
    }
    void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }
    public string GetPlayerSide()
    {
        return playerSide;
    }
    public void EndTurn()
    {
        if(buttonList[0].text == playerSide && buttonList[1].text == playerSide &&buttonList[2].text == playerSide)
        {
            DisplayText.text = $"Player {playerSide} Wins!";
            GameOver();
        }
        if(buttonList[3].text == playerSide && buttonList[4].text == playerSide &&buttonList[5].text == playerSide)
        {
            DisplayText.text = $"Player {playerSide} Wins!"; 
            GameOver();
        }if(buttonList[6].text == playerSide && buttonList[7].text == playerSide &&buttonList[8].text == playerSide)
        {
            DisplayText.text = $"Player {playerSide} Wins!"; 
            GameOver();
        }
        if(buttonList[0].text == playerSide && buttonList[3].text == playerSide &&buttonList[6].text == playerSide)
        {
            DisplayText.text = $"Player {playerSide} Wins!"; 
            GameOver();
        }
        if(buttonList[1].text == playerSide && buttonList[4].text == playerSide &&buttonList[7].text == playerSide)
        {
            DisplayText.text = $"Player {playerSide} Wins!"; 
            GameOver();
        }
        if(buttonList[2].text == playerSide && buttonList[5].text == playerSide &&buttonList[8].text == playerSide)
        {
            DisplayText.text = $"Player {playerSide} Wins!"; 
            GameOver();
        }
        if(buttonList[0].text == playerSide && buttonList[4].text == playerSide &&buttonList[8].text == playerSide)
        {   
            DisplayText.text = $"Player {playerSide} Wins!"; 
            GameOver();
        }
        if(buttonList[2].text == playerSide && buttonList[4].text == playerSide &&buttonList[6].text == playerSide)
        {
            DisplayText.text = $"Player {playerSide} Wins!"; 
            GameOver();

        }
        else
        {
            ChangeSides();
            DisplayText.text = $"Player {playerSide}'s Turn";
        }
    }
    void GameOver()
    {

        for(int i = 0; i < buttonList.Length; i++)
        {
            
            buttonList[i].GetComponentInParent<Button>().interactable = false;
        }

    }


    void ChangeSides()
    {
        playerSide = (playerSide == "X") ? "O" : "X";

    }

    public void Restart()
    {
        DisplayText.text = $"Tic Tac Toe";

        for(int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].text = "";
            buttonList[i].GetComponentInParent<Button>().interactable = true;
        }

    }

}

