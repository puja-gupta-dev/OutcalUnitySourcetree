using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMasterScene : MonoBehaviour
{
    [SerializeField]
    Button _button;

    [SerializeField]
    string _sceneName;

    private void Start()
    {
        _button.onClick.AddListener(() => OnBackButtonClick());
    }

    void OnBackButtonClick()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
