using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace player
{
    public class LoadScene : MonoBehaviour
    {
      public string _sceneName = "Scene_";

        [SerializeField]
        Button _button1,_button2,_button3;
        // Start is called before the first frame update
        void Start()
        {
            _button1.onClick.AddListener(() => onButtonClick(1));
            _button2.onClick.AddListener(() => onButtonClick(2));
            _button3.onClick.AddListener(() => onButtonClick(3));
        }

        void onButtonClick(int num)
        {
            SceneManager.LoadScene(_sceneName+num);
        }
        
    }
}
