using System.Collections.Generic;
using UnityEngine;

public class Prompt : MonoBehaviour
{
    [SerializeField] public List<GameObject> _variantsPrompt;
    [SerializeField] public List<GameObject> _variantPrompt;

    private int _randromPrompt;

    private UIManagment _managment;

    private void Awake()
    {
        _managment = FindObjectOfType<UIManagment>();
        _variantPrompt = new List<GameObject>(_variantsPrompt);
    }

    private void Update()
    {
        if (_managment._isNewPrompt)
        {
            _variantPrompt = new List<GameObject>(_variantsPrompt);
        }
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
        if(_variantPrompt.Count > 0)
        {
            _randromPrompt = Random.Range(0, _variantPrompt.Count);
            if (_variantPrompt[_randromPrompt] != null)
                _variantPrompt[_randromPrompt].SetActive(!_managment._isPrompt);
            else
            {
                _randromPrompt = Random.Range(0, _variantPrompt.Count);
                UsePrompt();
            }
            _variantPrompt.RemoveAt(_randromPrompt);
        }
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
