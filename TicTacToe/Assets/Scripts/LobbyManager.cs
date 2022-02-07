using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject playGameUI;

    // Start is called before the first frame update
    void Start()
    {
        playGameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.PlayerIsInside())
        {
            EnablePlayGameUI();

            if(Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }
        }
        else
        {
            DisablePlayGameUI();
        }
    }

    void EnablePlayGameUI()
    {
        playGameUI.SetActive(true);
    }

    void DisablePlayGameUI()
    {
        playGameUI.SetActive(false);
    }

    public void StartGame()
    {

    }
}
