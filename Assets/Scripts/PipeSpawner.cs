using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private PipesMove _pipesPrefab;



    void Start()
    {
        StartCoroutine(SpawnPipes());
    }
    private IEnumerator SpawnPipes()
    {
        var wait = new WaitForSeconds(2);

        while (true)
        {
            yield return wait;

            float rand = Random.Range(-1f, 4f);
            var pipe = Instantiate(_pipesPrefab, new Vector2(12.8f, rand), Quaternion.identity);
            Destroy(pipe.gameObject, 15);
        }
    }
    
}
