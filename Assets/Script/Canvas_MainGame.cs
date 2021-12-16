using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Threading;
using FirstGame.Player;

namespace FirstGame.Food.UI
{
    public class Canvas_MainGame : MonoBehaviour
    {
        [SerializeField]
        private Button _btnMenu;
        [SerializeField]
        private TextMeshProUGUI _txtTime;
        [SerializeField]
        private TextMeshProUGUI _txtScore;

        private float _timeCount;
        private Coroutine _coutingTimeCoroutine;

        public float TimeCount
        {
            get => _timeCount;
            set
            {
                _timeCount = value;
                _txtTime.SetText($"Time: {(int)_timeCount}");
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            _btnMenu.onClick.AddListener(Handle_OnBtnMenuClicked);
            //_coutingTimeCoroutine = StartCoroutine(IECoutingTime());
            string[] enemies = new string[] { "Enemy_1", "Enemy_2", "Enemy_3", "Enemy_4", "Enemy_5" };
            StartCoroutine(IESpawnEnemy(enemies));

            //PlayerController.Event_OnPickup += Handle_Event_OnPickup;
        }

        private void OnEnable()
        {
            // Subcribe
            //PlayerController.Event_OnPickup += Handle_Event_OnPickup;
            PlayerController.EventUnity_OnPickup.AddListener(Handle_Event_OnPickup);
        }

        private void OnDisable()
        {
            // Unsubcribe
            //PlayerController.Event_OnPickup -= Handle_Event_OnPickup;
            if (PlayerController.EventUnity_OnPickup != null)
            {
                PlayerController.EventUnity_OnPickup.RemoveListener(Handle_Event_OnPickup);
            }
        }

        private void Handle_Event_OnPickup(int score)
        {
            _txtScore.SetText($"Score: {score}");
        }

        private void OnDestroy()
        {
            //PlayerController.Event_OnPickup -= Handle_Event_OnPickup;
        }

        [ContextMenu("StopCoutingTime")]
        private void StopCoutingTime()
        {
            StopCoroutine(_coutingTimeCoroutine);
            //StopAllCoroutines();
            //var anotherCouroutine = IECoutingTime();
            //StopCoroutine(IECoutingTime());
        }

        private IEnumerator IESpawnEnemy(string[] enemies)
        {
            Debug.Log("IESpawnEnemy");
            var wait = new WaitForSeconds(10);
            while (true)
            {
                yield return wait;
                Debug.Log($"Spawn {enemies[0]}");
            }
        }

        //private IEnumerator IESpawnEnemy(string[] enemies)
        //{
        //    Debug.Log("IESpawnEnemy");
        //    var wait = new WaitForSeconds(1.0f);
        //    while (true)
        //    {
        //        TimeCount++;
        //        yield return wait;
        //        Debug.Log($"Time = {TimeCount}");

        //        if (TimeCount == 5)
        //        {
        //            Debug.Log($"Spawn {enemies[0]}");

        //        }
        //        else if (TimeCount == 10)
        //        {
        //            Debug.Log($"Spawn {enemies[1]}");

        //        }
        //        else if (TimeCount == 20)
        //        {
        //            Debug.Log($"Spawn {enemies[2]}");

        //        }
        //    }
        //}

        private IEnumerator IECoutingTime()
        {
            //float levelTime = 5f;
            //while(TimeCount < levelTime)
            //var wait = new WaitForEndOfFrame();
            var wait = new WaitForSeconds(1.0f);
            while (true)
            {
                Debug.Log("Start WaitForSeconds.");
                TimeCount++;
                yield return wait;
                //Debug.Log($"IECoutingTime() {TimeCount}");
                Debug.Log("End WaitForSeconds.");
            }

            Debug.Log($"Finish!");
        }

        private void Update()
        {
            //_timeCount += Time.deltaTime;
            //_txtTime.SetText(((int)_timeCount).ToString());
            //_txtTime.SetText($"Time: {(int)_timeCount}");

            //Debug.Log("Update");
        }

        public void Handle_OnBtnMenuClicked()
        {
            Debug.Log("Handle_OnBtnMenuClicked()");
            SceneManager.LoadScene(0);
        }
    }
}
