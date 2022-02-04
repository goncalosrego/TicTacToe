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
        if(playerMovement.PlayerCollided())
        {
            EnablePlayGameUI();
        }
    }

    void EnablePlayGameUI()
    {
        playGameUI.SetActive(true);
    }

    public void StartGame()
    {

    }
}
