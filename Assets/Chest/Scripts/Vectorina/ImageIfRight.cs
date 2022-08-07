using UnityEngine;
using UnityEngine.UI;

public class ImageIfRight : MonoBehaviour
{
    [SerializeField] private Variants _variant;

    private UIManagment _uiManagment;

    private Color _color;

    private bool _isComplete;

    private void Start()
    {
        _uiManagment = FindObjectOfType<UIManagment>();
        _color = transform.GetComponent<Image>().color;
        transform.GetComponent<Image>().color = new Color(0f, 0f, 0f);
    }

    private void Update()
    {
        CheckVariant();
    }
    public void CheckVariant()
    {
        if (_uiManagment._isRightAnswer && !_isComplete)
        {
            transform.GetComponent<Image>().color = _color;
           //_uiManagment._levels[_uiManagment._nowLevel].SetActive(false);
            _isComplete = true;
        }
        if(!_uiManagment._isRightAnswer)
        {
            transform.GetComponent<Image>().color = new Color(0f, 0f, 0f);
            _isComplete = false;
        }
    }
}
