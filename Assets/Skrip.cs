using UnityEngine;

public class Skrip : MonoBehaviour
{
    public Rigidbody2D Mybody;
    public float flapstrenght;
    public Logic logic;
    public bool birdalive = true;
    void Start()
    {
        gameObject.name = "Red Seed";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdalive == true)
        {
            Mybody.linearVelocity = Vector2.up * flapstrenght;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdalive = false;
    }
}
