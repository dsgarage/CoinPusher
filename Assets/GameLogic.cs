using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private Text scoreView;
    [SerializeField] private int score = 0;
    List<GameObject> _coinList = new List<GameObject>();

    public void Init()
    {
        score = 0;
        scoreView.text = score.ToString();

        for (int i = 0; i < _coinList.Count; i++)
        {
            Destroy(_coinList[i]);
            Debug.Log(_coinList.Count);
        }
        _coinList.Clear();
    }

    private void Start()
    {
        Init();
    }

    public void SetScore(int addScore)
    {
        score = addScore;
        scoreView.text = score.ToString();
    }

    public void AddCoinList(GameObject coin)
    {
        _coinList.Add(coin);
        Debug.Log("Coin:" + _coinList.Count);
    }
}
