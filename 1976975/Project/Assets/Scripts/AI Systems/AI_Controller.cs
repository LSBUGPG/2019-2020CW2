using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls the AI Spawns. You can control the max number of enemies in the level at one time, put unlimited spawn points in and you can also put in as many enemy types as you want. You can change what round they start spawning in and their health value 
/// </summary>
public class AI_Controller : MonoBehaviour
{
    public int maxNumbOfEnemies;
    public Transform[] spawnPoints;
    public List<Enemy_Info> enemyTypes = new List<Enemy_Info>();

    private List<GameObject> spawnedEnemies = new List<GameObject>();
    private List<GameObject> spawnPool = new List<GameObject>();
    [HideInInspector] public int enemyIndex;
    private Transform parent;
    private Game_Controller gC;

    /// <summary>References parent and Game Controller</summary>
    /// <example>
    ///   <code>void Start()
    /// {
    ///     gC = GameObject.Find("Game Controller").GetComponent&lt;Game_Controller&gt;();
    ///     parent = GameObject.Find("ENEMIES").GetComponent&lt;Transform&gt;();
    /// }</code>
    /// </example>
    void Start()
    {
        gC = GameObject.Find("Game Controller").GetComponent<Game_Controller>();
        parent = GameObject.Find("ENEMIES").GetComponent<Transform>();
    }

    /// <summary>Spawns an enemy.</summary>
    /// <remarks>Takes the indexRoll from EnemyIndexRoll and spawns the corresponding enemy from the Spawn Pool if there isn't enough enemies on screen.</remarks>
    /// <example>
    ///   <code>public void SpawnEnemy() 
    /// {
    ///     if (spawnedEnemies.Count &lt;= maxNumbOfEnemies)
    ///     {
    ///         GameObject enemy = Instantiate(spawnPool[enemyIndex], spawnPoints[Random.Range(0, spawnPoints.Length)].position, spawnPoints[0].rotation) as GameObject;
    ///         enemy.transform.SetParent(parent);
    ///         spawnedEnemies.Add(enemy);
    ///     }
    /// }</code>
    /// </example>
    public void SpawnEnemy() 
    {
        if (spawnedEnemies.Count <= maxNumbOfEnemies)
        {
            GameObject enemy = Instantiate(spawnPool[enemyIndex], spawnPoints[Random.Range(0, spawnPoints.Length)].position, spawnPoints[0].rotation) as GameObject;
            enemy.transform.SetParent(parent);
            spawnedEnemies.Add(enemy);
        }
    }

    private int lastEnemyIndex;
    /// <summary>Rolls an index number that is passed to the Spawn Function</summary>
    /// <remarks>Rolls an index number. If the number is the same as the last enemy roll it is rolled again. If there is only one enemy type index is always 0</remarks>
    /// <example>
    ///   <code>private int lastEnemyIndex;
    /// public void EnemyIndexRoll() 
    /// {
    ///     enemyIndex = Random.Range(0, spawnPool.Count);
    ///     if (spawnPool.Count == 1)
    ///     {
    ///         enemyIndex = 0;
    ///         SpawnEnemy();
    ///         return;
    ///     }
    ///
    ///     else
    ///     {
    ///         if (enemyIndex == lastEnemyIndex)
    ///         {
    ///             EnemyIndexRoll();
    ///         }
    ///
    ///         else
    ///         {
    ///             lastEnemyIndex = enemyIndex;
    ///             SpawnEnemy();
    ///         }
    ///     }
    /// }</code>
    /// </example>
    public void EnemyIndexRoll() 
    {
        enemyIndex = Random.Range(0, spawnPool.Count);
        if (spawnPool.Count == 1)
        {
            enemyIndex = 0;
            SpawnEnemy();
            return;
        }

        else
        {
            if (enemyIndex == lastEnemyIndex)
            {
                EnemyIndexRoll();
            }

            else
            {
                lastEnemyIndex = enemyIndex;
                SpawnEnemy();
            }
        }
    }

    /// <summary>Removes from list.</summary>
    /// <param name="objToRemove">The object to remove.</param>
    /// <remarks>When an enemy dies they're removed from the alive list so more enemies can spawn</remarks>
    /// <example>
    ///   <code>public void RemoveFromList(GameObject objToRemove) 
    ///  {
    ///      spawnedEnemies.Remove(objToRemove);
    ///  }</code>
    /// </example>
    public void RemoveFromList(GameObject objToRemove) 
    {
        spawnedEnemies.Remove(objToRemove);
    }

    /// <summary>Updates the spawn pool.</summary>
    /// <remarks>Repeats depending on how many enemy types there are. If the current round equals the spawn round then the enemy is added to the spawn pool</remarks>
    /// <example>
    ///   <code>public void UpdateSpawnPool() 
    ///  {
    ///      for (int i = 0; i &lt; enemyTypes.Count; i++)
    ///      {
    ///          Mathf.Clamp(i, 0, enemyTypes.Count - 1);
    ///          if (gC.currRound == enemyTypes[i].roundToSpawn)
    ///          {
    ///              spawnPool.Add(enemyTypes[i].enemyPrefab);
    ///          }
    ///      }
    ///  }</code>
    /// </example>
    public void UpdateSpawnPool() 
    {
        for (int i = 0; i < enemyTypes.Count; i++)
        {
            Mathf.Clamp(i, 0, enemyTypes.Count - 1);
            if (gC.currRound == enemyTypes[i].roundToSpawn)
            {
                spawnPool.Add(enemyTypes[i].enemyPrefab);
            }
        }
    }

    /// <summary>Data class that stores enemy info such as spawn round and spawn HP</summary>
    [System.Serializable]
    public class Enemy_Info
    {
        public string name;
        public GameObject enemyPrefab;
        [Range(1, 999)] public float health;
        [Range(1,99)] public int roundToSpawn;
    }
}
