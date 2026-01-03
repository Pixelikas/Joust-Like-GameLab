using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
   
    // Variables to players prefabs components (GameObject)
    public GameObject playerOnePrefab;
    public GameObject playerTwoPrefab;

    // Variables to players spawnpoints (Transform)
    public Transform playerOneSpawnPoint;
    public Transform playerTwoSpawnPoint;

    void Start()
    {

        // Call spawn method to create players
        SpawnGamePlayers();
        
    }

    void SpawnGamePlayers(){

        // Create players
        Instantiate(playerOnePrefab, playerOneSpawnPoint);
        Instantiate(playerTwoPrefab, playerTwoSpawnPoint);

    }

}
