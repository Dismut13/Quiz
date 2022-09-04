using UnityEngine;

public class CoinsSystem : MonoBehaviour
{
    public int _coins;
    public int _highScore;
    public int _nowScore;

    private UIManagment _uiManagment;

    private void Awake()
    {
        _uiManagment = GetComponent<UIManagment>();
    }

    public int GetCoin()
    {
        return _coins;
    }
    public void SetSystem(int setCoin, int setScore)
    {
        _coins = setCoin;
        if(_highScore <= _nowScore && _highScore < _uiManagment._levels.Length)
        {
            _highScore = _nowScore;
        }
        _nowScore = setScore;
    }
    public void PlusCoin(int plus)
    {
        _coins += plus;
    }
    public void MinusCoin(int minus)
    {
        _coins -= minus;
    }
}
