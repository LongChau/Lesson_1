using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cho phep ban keo tha vao trong object unity
// Mac dinh ke thua MonoBehaviour de viet behaviour cho object.
namespace Lesson1   // Quan trong.
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            Debug.Log("Awake()");
        }

        // This function is called when the object becomes enabled and active
        private void OnEnable()
        {
            Debug.Log("OnEnable()");
        }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Start()");

        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log("Update()");
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Pressed right arrow key!");
                transform.position += Vector3.right;
                //transform.position += new Vector3(1f, 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Pressed left arrow key!");
                transform.position += Vector3.left;
            }
        }

        private void OnDisable()
        {
            Debug.Log("OnDisable()");
        }

        private void OnDestroy()
        {
            Debug.Log("OnDestroy()");
        }
    }
}
