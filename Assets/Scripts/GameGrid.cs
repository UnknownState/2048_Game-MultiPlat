using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour {

    #region Public
    public GameObject EmptyTilePrefab;
    public int MaxDefaultSpawnCount = 3;
    [Space]
    public List<GameObject> EmptyTiles;

    #endregion
    #region Private
	
    #endregion

    #region Unity Callback
    void Start ()
    {
        
        int randomSpawnCount = Random.Range(1, MaxDefaultSpawnCount);

        List<GameObject> spawnPoints = new List<GameObject>();
        int previousSpawnIndex = -1;

        while (spawnPoints.Count < randomSpawnCount)
        {
            //Get a random index to spawn the tile at
            int randomSpawnIndex = Random.Range(0, EmptyTiles.Count - 1);
            //Check if the spawn index has already been used
            if (randomSpawnIndex == previousSpawnIndex)
                continue;
            //Set the previous spawn index to keep duplicate tiles from spawning
            previousSpawnIndex = randomSpawnIndex;
            //Add a new spawn point
            spawnPoints.Add(EmptyTiles[randomSpawnIndex]);
        }

        foreach (var t in spawnPoints)
        {
            Instantiate(EmptyTilePrefab, t.transform);
        }
    }

    #endregion
    #region Methods
	
    #endregion
}