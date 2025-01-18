using UnityEngine;

public class Summon : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 3;
    private float timer = 0;
    public float heigtofset = 10;

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
        float lowestpoint = transform.position.y - heigtofset;
        float highestpoint = transform.position.y + heigtofset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
