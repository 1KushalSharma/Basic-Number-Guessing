using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberGame : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI GuessText;
    int guess;
   public int chances;
    void Start()
    {
        StartGame();   
    }
    void StartGame()
    {

        guess = Random.Range(min,max+1);
        GuessText.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        min = guess+1;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess-1;
        NextGuess();
    }
    public void NextGuess()
    {
        guess = Random.Range(min, max+1);
        GuessText.text = guess.ToString();
        chances++;
        if(chances>5)
        {
            SceneManager.LoadScene(0);
        }
    }
}
