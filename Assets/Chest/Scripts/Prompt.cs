using UnityEngine;

public class Prompt : MonoBehaviour
{
    [SerializeField] private GameObject[] _variantsPrompt;
    [SerializeField] private GameObject[] _variantPrompt;
    [SerializeField] private GameObject[] _testPrompt;

    private int _randromPrompt;

    private UIManagment _managment;

    private void Awake()
    {
        _managment = FindObjectOfType<UIManagment>();
        _variantPrompt = _variantsPrompt;
        _testPrompt = _variantsPrompt;
    }

    private void Update()
    {
        if (_managment._isPrompt)
        {
            UsePrompt();
            _managment._isPrompt = false;
        }
        if (_managment._isRePrompt)
        {
            RePrompt();
            _managment._isRePrompt = false;
        }
    }

    private void UsePrompt()
    {
        _randromPrompt = Random.Range(0, _variantPrompt.Length);
        if(_variantPrompt[_randromPrompt] != null)
            _variantPrompt[_randromPrompt].SetActive(!_managment._isPrompt);
        else
        {
            _randromPrompt = Random.Range(0, _variantPrompt.Length);
            UsePrompt();
        }
        _variantPrompt[_randromPrompt] = null;
    }
    private void RePrompt()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).TryGetComponent<Variants>(out Variants v))
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
