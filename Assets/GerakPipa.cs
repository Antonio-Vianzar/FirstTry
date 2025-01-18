using UnityEngine;

public class GerakPipa : MonoBehaviour
{
    public float movespeed = 5;
    public float deadzone = -30; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
