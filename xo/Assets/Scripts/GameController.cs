using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameController : MonoBehaviour
{
    public TMP_Text[] buttonList;

    public string playerSide;
    public TMP_Text DisplayText;

    public GameObject[] strikeoutList;


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
            strikeoutList[0].SetActive(true);
            GameOver();
        }
        if(buttonList[3].text == playerSide && buttonList[4].text == playerSide &&buttonList[5].text == playerSide)
        {
            strikeoutList[1].SetActive(true);
            GameOver();
        }if(buttonList[6].text == playerSide && buttonList[7].text == playerSide &&buttonList[8].text == playerSide)
        {
            strikeoutList[2].SetActive(true);
            GameOver();
        }
        if(buttonList[0].text == playerSide && buttonList[3].text == playerSide &&buttonList[6].text == playerSide)
        { 
            strikeoutList[3].SetActive(true);
            GameOver();
        }
        if(buttonList[1].text == playerSide && buttonList[4].text == playerSide &&buttonList[7].text == playerSide)
        { 
            strikeoutList[4].SetActive(true);
            GameOver();
        }
        if(buttonList[2].text == playerSide && buttonList[5].text == playerSide &&buttonList[8].text == playerSide)
        { 
            strikeoutList[5].SetActive(true);
            GameOver();
        }
        if(buttonList[0].text == playerSide && buttonList[4].text == playerSide &&buttonList[8].text == playerSide)
        {    
            strikeoutList[6].SetActive(true);
            GameOver();
        }
        if(buttonList[2].text == playerSide && buttonList[4].text == playerSide &&buttonList[6].text == playerSide)
        {
            strikeoutList[7].SetActive(true);
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

        DisplayText.text = $"Player {playerSide} Wins!";
        

    }



    void ChangeSides()
    {
        playerSide = (playerSide == "X") ? "O" : "X";

    }

    public void Restart()
    {
        for(int i = 0; i < strikeoutList.Length; i++)
        {
            strikeoutList[i].SetActive(false);
        }

        DisplayText.text = $"Tic Tac Toe";

        for(int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].text = "";
            buttonList[i].GetComponentInParent<Button>().interactable = true;
        }

    }

}

