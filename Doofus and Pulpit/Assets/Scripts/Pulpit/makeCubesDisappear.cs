using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCubesDisappear : MonoBehaviour
{
    public float min_pulpit_destroy_time = 4f;
    public float max_pulpit_destroy_time = 5f;
    public float pulpit_spawn_time = 2.5f;
    public float[] possiblepossitionsx = { -10f,  0f,  10f};
    public float[] possiblepossitionsz = { -10f, 0f,  10f };
    public GameObject reference;
    private int possiblecube = 2;
    private int count=0;
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (count < possiblecube) StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
       yield return new WaitForSeconds(pulpit_spawn_time);
        Instantiate(reference, new Vector3(possiblepossitionsx[Random.Range(0,2)],0, possiblepossitionsz[Random.Range(0,2)]), Quaternion.identity);
        count++;
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ground")
        {
            StartCoroutine(destroyed());
            target.gameObject.SetActive(false);
            count--;
        }
    }
    IEnumerator destroyed()
    {
        yield return new WaitForSeconds(Random.Range(min_pulpit_destroy_time, max_pulpit_destroy_time));
    }
}
