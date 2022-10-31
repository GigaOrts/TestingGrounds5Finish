using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> targets;

    private float spawnRate = 1f;

    void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    private IEnumerator SpawnTarget()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Capacity);

            Instantiate(targets[index]);
        }
    }
}
