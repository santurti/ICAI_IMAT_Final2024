using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeFactory : MonoBehaviour
{
    public bool isplayer { get; set; }
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject cube;

    public GameObject CreateShape(bool isPlayer)
    {
        if (isPlayer)
        {
            // instancia y debuelve el prefab de la esfera roja
            return ball;
        }
        // instancia y debuelve el prefab del 
        return cube;
    }        
}
