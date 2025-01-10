using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private List<GameObject> boardPositions;

    private bool isPlayerTourn = true;

    private string lastKeyPressed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown && !string.IsNullOrEmpty(Input.inputString))
        {
            lastKeyPressed = Input.inputString;
            
            Debug.Log("Key pressed: " + lastKeyPressed);
        }
    }


    /// <summary>
    /// Assumtion:
    /// GetCurrentWinner gets a list where positions 0-8 have a -1 if AI placed ball 0 if none did and 1 if player did
    /// </summary>
    /// <returns>int deciding who won (-1 win IA, 1 win human, 0 draw) </returns>
    public int GetWinner(List<int> gameState) 
    {
        //condition rules
        //horizontal
        bool winH1 = (gameState[0] == gameState[1] && gameState[1] == gameState[2]);
        bool winH2 = (gameState[3] == gameState[4] && gameState[4] == gameState[5]);
        bool winH3 = (gameState[6] == gameState[7] && gameState[7] == gameState[8]);

        //vertical
        bool winv1 = (gameState[0] == gameState[3] && gameState[3] == gameState[6]);
        bool winv2 = (gameState[1] == gameState[4] && gameState[4] == gameState[7]);
        bool winv3 = (gameState[2] == gameState[5] && gameState[5] == gameState[8]);

        // oblicue
        bool winO1 = (gameState[0] == gameState[4] && gameState[4] == gameState[8]);
        bool winO2 = (gameState[6] == gameState[4] && gameState[4] == gameState[2]);
        
        if (winH1) { return gameState[0]; }
        else if (winH1 | winv1) { return gameState[0]; }
        else if (winH2 | winv2 | winO1 | winO2) { return gameState[4]; }
        else if (winH3 | winv3) { return gameState[8]; }
        else { return 0; }
    }
    public string GetCurrentWinner(List<int> gameState)
    {
        int currentWinner = GetWinner(gameState);
        if (currentWinner == 0) { return "empate"; }
        else if (currentWinner == 1) { return "Victoria"; }
        else { return "Derrota"; }
    }
}
