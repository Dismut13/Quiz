using UnityEngine;

public class CoinsSystem : MonoBehaviour
{
    public int _coins;
    public int _score;

    public int GetCoin()
    {
        return _coins;
    }
    public void SetSystem(int setCoin, int setScore)
    {
        _coins = setCoin;
        _score = setScore;
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
