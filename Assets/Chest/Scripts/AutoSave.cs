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
        PlayerPrefs.Save();
    }

    public void LoadGame()
    {
        _coins._coins = PlayerPrefs.GetInt("Coins");
        _coins._highScore = PlayerPrefs.GetInt("Score");
        _uiManagment._isNewPrompt = false;
    }

    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
        _coins._coins = 0;
        _coins._highScore = 0;
        _uiManagment._nowLevel = 0;
    }
}
