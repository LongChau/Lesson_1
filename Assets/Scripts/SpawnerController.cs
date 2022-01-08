using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson1
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField]
        private ItemController[] _items;

        [SerializeField]
        private bool _isRepeating;

        [SerializeField]
        private PlayerController _player;

        private float _nextSpawnTime = 0f;

        private Coroutine _instantiateItemsCoroutine;

        // Start is called before the first frame update
        void Start()
        {
            // Tao item.
            //Instantiate(_item, transform.position, transform.rotation);
            //IEInstantiateItems(); // => Khong chay.
            //StartCoroutine(IEInstantiateItems()); // => Cach chay coroutine dung.

            // Cach 1: Su dung coroutine. 
            //for (int i = 0; i < 100; i++)
            //{
            //    StartCoroutine(IEInstantiateItems(i));
            //}

            //StartCoroutine(IEInstantiateInfiniteItems());

            // Cach 2: Su dung Invoke
            //InvokeRepeating("InstantiateItems", 0f, 1f);

            // Cach 3: Su dung kem while voi waitforsecond = 1.
            _instantiateItemsCoroutine = StartCoroutine(IEInstantiateInfiniteItems());

            // Listen event OnPlayerDead của player.
            _player.OnPlayerDead.AddListener(Handle_OnPlayerDead);
        }

        private void Handle_OnPlayerDead()
        {
            Debug.Log("Handle_OnPlayerDead");
            // Cách xài stop couroutine bậy bạ!!!!
            //StopCoroutine(IEInstantiateInfiniteItems());
            // Cách xài StopCoroutine đúng. 
            StopCoroutine(_instantiateItemsCoroutine);
        }

        //IEnumerator IEInstantiateItems(int itemIndex)
        //{
        //    float waitTime = 1.0f;
        //    yield return new WaitForSecondsRealtime(waitTime + itemIndex);
        //    Instantiate(_item, transform.position, transform.rotation);
        //}

        IEnumerator IEInstantiateInfiniteItems()
        {
            // Cached wait.
            float waitTime = Random.Range(1f, 3f);
            var wait = new WaitForSecondsRealtime(waitTime);
            while (_isRepeating)
            {
                // Cach 1: Check player isDead thì yield break.
                //if (_player.IsDead)
                //    yield break;

                // Sau moi 1 giay thì mình không sinh ra thêm WaitForSecondsRealtime.
                yield return wait;
                int itemIndex = Random.Range(0, _items.Length);
                Instantiate(_items[itemIndex], transform.position, transform.rotation);
            }
        }

        //private void InstantiateItems()
        //{
        //    Instantiate(_item.gameObject, transform.position, transform.rotation);
        //}

        // Update is called once per frame
        void Update()
        {
            //Instantiate(_item, transform.position, transform.rotation);
            // Cach 4: Dung update.
            //_nextSpawnTime += Time.deltaTime;
            //if (_nextSpawnTime > 1f)
            //{
            //    _nextSpawnTime = 0f;
            //    InstantiateItems();
            //}
        }

        private void OnDestroy()
        {
            _player?.OnPlayerDead.RemoveListener(Handle_OnPlayerDead);
        }
    }
}
