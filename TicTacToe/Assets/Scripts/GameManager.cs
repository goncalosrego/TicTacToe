using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject xPiece;
    Vector2 pieceStartingPosition = new Vector2(-7f, -6f);
    Vector2 pieceOffset = new Vector2(3f, 0f);
    int numberOfGamePieces = 6;

    void Start()
    {
        InstantiateGamePieces();
    }

    void Update()
    {
        
    }

    void InstantiateGamePieces()
    {
        for(int i = 0; i < numberOfGamePieces; i++)
        {
            if(i == 0)
            {
                Instantiate(xPiece, pieceStartingPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(xPiece, pieceStartingPosition + pieceOffset, Quaternion.identity);
                pieceStartingPosition += pieceOffset;
            }
        }
    }
}
