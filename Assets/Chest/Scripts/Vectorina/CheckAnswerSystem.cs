using UnityEngine;
using UnityEngine.UI;

public class CheckAnswerSystem : MonoBehaviour
{
    [SerializeField] private Text _uiRightCount;

    [SerializeField] private CoinsSystem _scoreSystem;

    public int _rightAnswerCount;

    private void Update()
    {
        _uiRightCount.text = "High Score: " + _scoreSystem._highScore + "\n" + "Coins: " + _scoreSystem._coins;
    }
}
