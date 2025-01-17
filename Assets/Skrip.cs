using UnityEngine;

public class Skrip : MonoBehaviour
{
    public Rigidbody2D Mybody;
    public float flapstrenght;
    void Start()
    {
        gameObject.name = "Red Seed";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Mybody.linearVelocity = Vector2.up * flapstrenght;
        }
    }
}
