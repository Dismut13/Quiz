using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    public Variants[] _v;

    public MainMenuM _mainM;

    private void Update()
    {
        if (_mainM.gameObject.activeSelf)
        {
            for(int i = 0; i < _v.Length; i++)
            {
                _v[i]._isButtonDowned = false;
            }
        }
    }
}
