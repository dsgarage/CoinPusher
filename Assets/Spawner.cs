using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private GameLogic _gameLogic;

    private void Awake()
    {
        _gameLogic = FindObjectOfType<GameLogic>();
    }

    void Start () {
    }
    void Update () {
        if (Input.GetKeyDown("space"))
        {
            _gameLogic.AddCoinList(Instantiate(coin,this.transform.position,this.transform.rotation));
        }
    }

}
