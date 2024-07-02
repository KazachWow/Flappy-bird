using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    private int _score;

    private void Update()
    {
        _scoreText.text = _score.ToString();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _score++;
        }

    }


}
