using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lession1
{
    public class CanvasMenu : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        public void OnBtnStartClicked()
        {
            SceneManager.LoadSceneAsync("GameScene");
        }

        public void OnBtnQuitClicked()
        {
            Application.Quit();
        }
    }
}
