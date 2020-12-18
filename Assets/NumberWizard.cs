using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxguess = 1000;
    int minguess = 1;
    int guess = 500;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        maxguess = maxguess + 1;
        Debug.Log("Thanks for participating, now we will give you a little test");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: " + maxguess);
        Debug.Log("Lowest number is: " + minguess);
        Debug.Log("Tell me if you number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push enter = Correct");

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            minguess = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxguess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Porque tonan wn pencas?");
            StartGame();
        }
    
    }
    void NextGuess()
    {
        guess = (maxguess + minguess) / 2;
        Debug.Log("Is Higher or lower than..." + guess);

    }
      
}
