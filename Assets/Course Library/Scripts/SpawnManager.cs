using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] spawnAnimals;
    private float xRange = 15.0f;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal()
    {
        if (spawnAnimals.Length == 0) return;

        int animalIndex = Random.Range(0, spawnAnimals.Length);
        GameObject sAnimal = Instantiate(spawnAnimals[animalIndex], new Vector3(Random.Range(-xRange, xRange), 0, 25), spawnAnimals[animalIndex].transform.rotation);

        //Randomize the speed of the animal
        MoveForward moveForward = sAnimal.GetComponent<MoveForward>();
        moveForward.speed = Random.Range(8.0f, 16.0f);
    }
}
