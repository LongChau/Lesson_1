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
        [SerializeField]
        private SpriteRenderer _spriteRender;
        [SerializeField]
        private Animator _anim;
        [SerializeField]
        private Rigidbody2D _rigid;
        [SerializeField]
        private int _score;

        private int _isLeft;

        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            Debug.Log("Awake()");
            _isLeft = Animator.StringToHash("isLeft");
            _score = 0;
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
                //Debug.Log("Pressed right arrow key!");
                //transform.position += Vector3.right * _speed * Time.deltaTime;
                transform.Translate(Vector2.right * _speed * Time.deltaTime);
                //_spriteRender.flipX = false;
                _anim.SetBool(_isLeft, false);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                //Debug.Log("Pressed left arrow key!");
                transform.position += Vector3.left * _speed * Time.deltaTime;
                //_spriteRender.flipX = true;
                _anim.SetBool("isLeft", true);
            }
        }

        // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
        private void OnTriggerEnter2D(Collider2D collider)
        {
            Debug.Log($"Collide with: {collider.name}");
            if (collider.CompareTag("Item"))    // Nên xài.
            //if (collider.tag == "Item")   // Không nên xài. Sinh ra cái "string" mới.
            {
                Debug.Log($"Collect!");
                Destroy(collider.gameObject);
                _score++;
                Debug.Log($"Score: {_score}");
            }
        }

        //// OnCollisionEnter2D is called when this collider2D/rigidbody2D has begun touching another rigidbody2D/collider2D (2D physics only)
        //private void OnCollisionEnter2D(Collision2D collision) {
        //    Debug.Log($"Collide with: {collision.collider.name}");
        //    // Chỉ chạy vào đây khi và chỉ khi isTrigger của collider = true.
        //}



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
