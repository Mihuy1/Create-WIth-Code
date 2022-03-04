using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private GameManagerX gamemanager;

    IEnumerator Countdown(int currentTime)
    {
        while (gamemanager.startTime > 0 && gamemanager.isGameActive != false)
        {
            gamemanager.startTime--;
            currentTime = gamemanager.startTime;
            gamemanager.countdownText.text = currentTime + " seconds left!";
            yield return new WaitForSeconds(1);
        }
        gamemanager.GameOver();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
