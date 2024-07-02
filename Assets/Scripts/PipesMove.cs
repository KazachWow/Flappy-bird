using UnityEngine;

public class PipesMove : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    void Update()
    {
        transform.Translate(-_speed * Time.deltaTime, 0, 0);
    }
}
