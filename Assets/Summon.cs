using UnityEngine;

public class Summon : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 3;
    private float timer = 0;

    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
