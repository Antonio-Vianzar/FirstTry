using UnityEngine;

public class Skrip : MonoBehaviour
{
    public Rigidbody2D Mybody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Red Seed";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Mybody.linearVelocity = Vector2.up * 10;
        }
    }
}
