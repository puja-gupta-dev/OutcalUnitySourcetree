using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace player
{
    public class LoadMasterScene : MonoBehaviour
    {
        public string _sceneName = "MainScene";

        [SerializeField]
        Button _button1;
        // Start is called before the first frame update
        void Start()
        {
            _button1.onClick.AddListener(() => OnBackButtonClick());
        }

        void OnBackButtonClick()
        {
             SceneManager.LoadScene(_sceneName);
        }
        
    }
}
