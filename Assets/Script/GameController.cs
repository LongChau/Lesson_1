using FirstGame.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace FirstGame.Food.Controller
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private PlayerController _playerPrefab;
        [SerializeField]
        private Transform _spawnPosition;

        private PlayerController _player;

        // Start is called before the first frame update
        void Start()
        {
            //Instantate player in the spawn location.
            _player = Instantiate(_playerPrefab, _spawnPosition.position, Quaternion.identity);

            // Khong nen xai. Performance giam rat nhieu...
            // Basic
            //var txtPos = GameObject.Find("txtPosition").GetComponent<TextMeshProUGUI>();
            //var txtScore = GameObject.Find("txtScore").GetComponent<TextMeshProUGUI>();
            //_player.AssignUI(txtScore, txtPos);
        }
    }
}
