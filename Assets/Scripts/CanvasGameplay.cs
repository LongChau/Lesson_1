using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lesson1
{
    public class CanvasGameplay : MonoBehaviour
    {
        [SerializeField]
        private RectTransform _pnlGameOver;
        [SerializeField]
        private TextMeshProUGUI _txtScore;
        [SerializeField]
        private TextMeshProUGUI _txtHp;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void OnBtnQuitClicked()
        {
            Debug.Log("OnBtnQuitClicked()");
            //Application.Quit();
            SceneManager.LoadSceneAsync("MenuScene");
        }

        public void UpdateScore(int score)
        {
            _txtScore.SetText($"Score: {score}");
        }

        public void UpdateHealth(int health)
        {
            _txtHp.SetText($"HP: {health}");
        }

        public void ShowGameOver()
        {
            _pnlGameOver.gameObject.SetActive(true);
        }

        public void HideGameOver()
        {
            _pnlGameOver.gameObject.SetActive(false);
        }

        public void OnBtnReplayCLicked()
        {
            //SceneManager.LoadScene("New Scene");
            SceneManager.LoadSceneAsync("GameScene");
        }
    }
}
