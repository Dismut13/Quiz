using UnityEngine;

public class CompletedThisAnswer : MonoBehaviour
{
    [SerializeField] private UIManagment _managment;

    private int _nowLevel;

    private void Update()
    {
        if(_managment._nowLevel < _managment._levels.Length)
            _managment._levels[_nowLevel].SetActive(!_managment._isMainMenuActive);
    }
}
