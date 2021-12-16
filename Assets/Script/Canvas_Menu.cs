using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace FirstGame.Food.UI
{
    public class Canvas_Menu : MonoBehaviour
    {
        [SerializeField]
        private Button _btnQuit;
        //[SerializeField]
        //private GameObject _testNull;

        // Start is called before the first frame update
        void Start()
        {
            _btnQuit.onClick.AddListener(Handle_BtnQuitClicked);
        }

        public void Handle_BtnQuitClicked()
        {
            Debug.Log("Handle_BtnQuitClicked");

        }

        public void Handle_BtnStartClicked()
        {
            Debug.Log("Handle_BtnStartClicked");
            //Debug.Log($"_testNull: {_testNull.name}");
            //SceneManager.LoadScene("MainGameScene");
            SceneManager.LoadScene(1);
        }
    }
}
