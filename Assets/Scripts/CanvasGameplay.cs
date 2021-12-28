using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson1
{
    public class CanvasGameplay : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        public void OnBtnQuitClicked()
        {
            Debug.Log("OnBtnQuitClicked()");
            Application.Quit();
        }

        private void OnBtnQuitClicked_2()
        {

        }
    }
}
