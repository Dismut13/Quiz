using UnityEngine;
using UnityEngine.UI;

public class CheckAnswerSystem : MonoBehaviour
{
    [SerializeField] public Text _uiRightCount;
    [SerializeField] public Text _uiHighScore;

    [SerializeField] private CoinsSystem _scoreSystem;

    public int _rightAnswerCount;

    private void Update()
    {
        _uiRightCount.text = "Score: " + _scoreSystem._nowScore + "\n" + "Coins: " + _scoreSystem._coins;
        _uiHighScore.text = "High Score: " + _scoreSystem._highScore;
    }
}
