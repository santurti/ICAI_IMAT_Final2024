using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private List<GameObject> boardPositions;

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
}
