using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    Button _button1,_button2,_button3;

    
    public  string _sceneName = "scene";

    // Start is called before the first frame update
    void Start()
    {
        _button1.onClick.AddListener(() => OnButtonClick(1));
        _button2.onClick.AddListener(() => OnButtonClick(2));
        _button3.onClick.AddListener(() => OnButtonClick(3));
    }

    void OnButtonClick(int num)
    {
        SceneManager.LoadScene(_sceneName + num);
    }

    
}
