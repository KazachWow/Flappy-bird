using System.Collections;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    [SerializeField]
    private PipesMove _healthPrefab;
    void Start()
    {
        StartCoroutine(SpawnHealth());
    }
    private IEnumerator SpawnHealth()
    {
        var wait = new WaitForSeconds(2);
        while (true)
        {
            yield return wait;

            float rand = Random.Range(-4f, 4f);
            var lives = Instantiate(_healthPrefab, new Vector2(12.8f, rand), Quaternion.identity);
            Destroy(lives.gameObject, 15);
        }
    }
    void Update()
    {
        
    }
}
