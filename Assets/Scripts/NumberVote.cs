using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NumberVote : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI voteText;

    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        NextGuess();
    }

    public void OnPressVoteUp()
    {
        min = guess + 1;
        NextGuess();
        
    }

    public void OnPressVoteDown()
    {
        max = guess ;
        NextGuess();
    }
    void NextGuess()
    {
        if (min < max)
        {
            guess = Random.Range(min, max);
        }
        else if (min == max)
        {
            guess = min;
        }
        else
        {
            min = guess;
        }

            voteText.text = guess.ToString();
    }
}
