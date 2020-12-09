using UnityEngine;

public class ScoreSetter : MonoBehaviour
{

    [SerializeField] private int addScoreValu = 0;
    [SerializeField] private GameLogic _gameLogic;

    private void Awake()
    {
        _gameLogic = FindObjectOfType<GameLogic>();
    }


    private void OnCollisionEnter(Collision other)
    {
        _gameLogic.SetScore(addScoreValu);
    }
}
