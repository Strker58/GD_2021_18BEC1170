using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCubesDisappear : MonoBehaviour
{
    public float pulpit_spawn_time = 2.5f;
    public float[] possiblepossitionsx = { -10f,  0f,  10f};
    public float[] possiblepossitionsz = { -10f, 0f,  10f };
    public GameObject reference;
    private int possiblecube = 2;
    public int count=0;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(reference, new Vector3(0, 0, 0), Quaternion.identity);
        count++;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (count < possiblecube)
        {
            StartCoroutine(Spawn());
            count++;
        }
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(pulpit_spawn_time);
        Instantiate(reference, new Vector3(possiblepossitionsx[Random.Range(0,3)],0, possiblepossitionsz[Random.Range(0,3)]), Quaternion.identity);
    }
    
}
