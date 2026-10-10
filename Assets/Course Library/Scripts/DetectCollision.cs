using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject burst;
    public GameObject soundObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            if (burst != null) Instantiate(burst, transform.position, transform.rotation);
            if (soundObject != null)
            {
                Instantiate(soundObject, transform.position, transform.rotation);
            }
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
