using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    public float spawnDelay = 1;
    float timer = 0;

    public BaseSpawner fruit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnDelay)
        {
            SpawnFruit(fruit);
            timer -= spawnDelay;
        }
    }

    public void SpawnFruit(BaseSpawner fruitSpawner)
    {
        fruitSpawner.SpawnCell(transform, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0));
    }
}
