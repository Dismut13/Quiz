using UnityEngine;
using UnityEngine.UI;

public class CheckAnswerSystem : MonoBehaviour
{
    public int _rightAnswerCount;

    [SerializeField] private Text _uiRightCount;

    private void Update()
    {
        _uiRightCount.text = _rightAnswerCount + "";
    }
}
