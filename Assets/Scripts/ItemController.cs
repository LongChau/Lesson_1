using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson1   // Quan trong.
{
    public class ItemController : MonoBehaviour
    {
        [SerializeField]
        private float _falldownSpeed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector2.down * _falldownSpeed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Land"))
            {
                Debug.Log("Reach land");
                Destroy(gameObject);
            }
        }
    }
}
