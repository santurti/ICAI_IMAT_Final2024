using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public PlayerState playerState = new PlayerState();
    public AIState aIState = new AIState();
    public int GetState(bool isPlayertourn)
    {
        if (isPlayertourn)
        {
            return playerState.PlayTurn();
        }
        return aIState.PlayTurn();
    }
    public virtual int PlayTurn() { return 0; }
}

public class PlayerState : State
{
    public PlayerState() 
    {
        
    }
    public int PlayTurn()
    {
        return 0;
    }
}

public class AIState : State
{
    public AIState() { }
    public int PlayTurn() 
    {
        return Random.Range(1, 9);
    }
}
