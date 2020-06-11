using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawn : MonoBehaviour {

    public enum SpawnState { Spawning, Waiting, Counting };

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform kiwi;
        public int count;  //Number of Kiwis
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public int remKiwi;
    bool KiwiLeft;

    public Text kiwisLeft;
    public Text announceText;

    public float timeBetweenWaves = 5f;
    public float waveCountdown;


    public SpawnState state = SpawnState.Counting;

    void Start()
    {
        waveCountdown = timeBetweenWaves;

    }


    // Update is called once per frame
    void Update()
    {
        kiwisLeft.text = ("Kiwis remaining: " + GameObject.FindGameObjectsWithTag("Kiwi").Length);

        if (state == SpawnState.Waiting)
        {
            if (KiwiLeft == false)
            {
                //start next wave
                WaveFinished();

            }
            else
            {
                return;
            }
        }
        if (waveCountdown <= 0)
        {
            if (state != SpawnState.Spawning)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    public void kiwiCheck()
    {
        if (remKiwi <= 0)
        {
            KiwiLeft = false;
        }
    }
    void WaveFinished()
    {
        announceText.text = ("stage complete!");
        state = SpawnState.Counting;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
        }
        else
        {
            nextWave++;
        }

    }
    IEnumerator SpawnWave(Wave _wave)
    {
        announceText.text = ("Spawning wave " + _wave.name);
        state = SpawnState.Spawning;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnKiwi(_wave.kiwi);
            yield return new WaitForSeconds(1f / _wave.rate);
            KiwiLeft = true;
        }


        state = SpawnState.Waiting;
        yield break;
    }

    void SpawnKiwi(Transform _kiwi)
    {
        float posX = Random.Range(-70f, 70f);
        float posZ = Random.Range(-70f, 70f);
        float posY = Random.Range(-10f, 50f);
        Instantiate(_kiwi, new Vector3(posX, posY, posZ), Quaternion.Euler(0f, 0f, 0f));
        remKiwi++;
    }
}

