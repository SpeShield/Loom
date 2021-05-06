using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // The GameObject to instantiate.
    public GameObject entityToSpawn;

    public GameObject parentEntity;
    // An instance of the ScriptableObject defined above.
    public TokenDataManager managerValues;

    // This will be appended to the name of the created entities and increment when each is created.
    
    void Awake()
    {
        SpawnEntities();
    }

    void SpawnEntities()
    {
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < managerValues.numberOfPrefabsToCreate; i++)
        {
            // Creates an instance of the prefab at the current spawn point.
            GameObject currentEntity = Instantiate(entityToSpawn, managerValues.initalSpawnPoint[currentSpawnPointIndex], Quaternion.identity);

            // Sets the name of the instantiated entity to be the string defined in the ScriptableObject and then appends it with a unique number. 
            currentEntity.name = managerValues.prefabNames[i];

            // Moves to the next spawn point index. If it goes out of range, it wraps back to the start.
            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % managerValues.initalSpawnPoint.Length;

            currentEntity.transform.parent = parentEntity.transform;

        }
    }
}
