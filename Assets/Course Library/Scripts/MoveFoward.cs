using UnityEngine;
using UnityEngine.UIElements;

public class MoveFoward : MonoBehaviour
{
    public float speed = 40.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()    
    {
            
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
    //Set Speed method
    public void SetSpeed(float newSpeed)   
    {
        speed = newSpeed;    
    }
}