using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TokenData", menuName = "ScriptableObjects/TokenDataManager", order = 1)]
public class TokenDataManager : ScriptableObject
{
    public int numberOfPrefabsToCreate;
    public string[] prefabNames;
    public Vector3[] initalSpawnPoint;
}
