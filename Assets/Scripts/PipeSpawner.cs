using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;

    public float spawnRate = 2f; // частота по€влени€ в сек
    public float heightOffset = 1f;//смещение диапазона смещени€ труб по вертикали




    void Start()
    {
        StartCoroutine(SpawnPipeRoutine());

    }
    IEnumerator SpawnPipeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds (spawnRate);// игровое врем€
            // yield return new WaitForSecondsRealTime (spawnRate) // реальное врем€
            
            // исполдьзовать с осторожностью!
            // yield return new WaitForFixedUpdate (spawnRate) // прив€зка к физике
            // yield return new WaitUntil (() => playerHealth <=0);
            //yield return new WaitWhile(() => isPaused);
            

            
            float yPos = Random.Range(-heightOffset, heightOffset); // random pipe positioning
            Vector3 spawnPosition = new Vector3 (transform.position.x, yPos, 0);
            Instantiate(pipesPrefab, spawnPosition, Quaternion.identity);



        }
    
    }
    /* ƒругие способы задержки

    2. Time.time - секундомер. ќтлично работает!

    
    float delayTime = 2f;
    float startTime;

    void Start()
    {
    startTime = Time.time;
    }

    void Update()
    {
    
    if (Time.time >= startTime + delayTime)
    {
    запускаю код
    
    }
    
    }

    3. Invoke //вызываетс€ 1 раз, поточный, не останавливаетс€.
    
    void Start ()

    {
    Invoke ("SpawnPipes", 2f);
    }

    void SpawnPipes()
    {
    код вызова труб
    }

    4. InvokeRepeating / меньше контрол€

    void Start()
    {
    InvokeRepeating ("SpawnPipes", 2f, 3f); вызову метод SpawnPipes (), через 2 секунды и повтор€ю через каждые 3 секунды
    }

    void SpawnPipes ()
    {
    код вызова труб
    }

    

    5. Update with Time.DeltaTime

    6. Task и async/await - сложно
    }

    */


    void Update()
    {
        
    }
}
