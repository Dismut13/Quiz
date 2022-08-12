using UnityEngine;
using UnityEngine.UI;

public class CheckAnswerSystem : MonoBehaviour
{
    [SerializeField] private Text _uiRightCount;

    [SerializeField] private CoinsSystem _scoreSystem;

    public int _rightAnswerCount;

    private void Update()
    {
        _uiRightCount.text = "Score: " + _scoreSystem._score + "\n" + "Coins: " + _scoreSystem._coins;
    }
}
