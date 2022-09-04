using UnityEngine;

public class AutoSave : MonoBehaviour
{
    public UIManagment _uiManagment;
    public CoinsSystem _coins;

    private void Awake()
    {
        LoadGame();
    }

    public void SaveGame(int coins, int score, int level)
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.Save();
    }

    public void LoadGame()
    {
        _coins._coins = PlayerPrefs.GetInt("Coins");
        _coins._score = PlayerPrefs.GetInt("Score");
        _uiManagment._nowLevel = PlayerPrefs.GetInt("Level");
    }

    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
        _coins._coins = 0;
        _coins._score = 0;
        _uiManagment._nowLevel = 0;
    }
}
