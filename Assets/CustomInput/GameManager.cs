using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyCode
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;

        [SerializeField] private GameObject activePlayer;
        public GameObject playerPrefab;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
        }

        private void Start()
        {
            SpawnPlayer();
        }

        public static GameManager GetInstance()
        {
            return instance;
        }

        private void SpawnPlayer()
        {
            if (playerPrefab != null)
            {
                activePlayer = Instantiate(playerPrefab);
            }
            else
            {
                Debug.LogWarning("Player Prefab is not assigned in GameManager!");
            }
        }

        public Vector3 GetPlayerPosition()
        {
            return activePlayer != null ? activePlayer.transform.position : Vector3.zero;
        }

        public GameObject GetActivePlayer()
        {
            return activePlayer;
        }
    }
}
