using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class ButtonExtensions
{
    public static void SubscribeOnClick(this Button button, UnityAction action) => button.onClick.AddListener(action);
    public static void SetObjectActive(this Component component, bool active) => component.gameObject.SetActive(active);
}

public class LivesCounter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _livesText;

    [SerializeField]
    private int _livesCounter;

    [SerializeField]
    private Button _restartButton;

    private void Awake()
    {
        _restartButton.SubscribeOnClick(HandleRestartClicked);
        _restartButton.SetObjectActive(false);
    }

    void Start()
    {
        _livesText.text = _livesCounter.ToString();
    }

    private void HandleRestartClicked()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            _livesCounter--;
            _livesText.text = _livesCounter.ToString();
            if (_livesCounter <= 0)

            {
                Time.timeScale = 0;
                _restartButton.SetObjectActive(true);
                Destroy(gameObject);
            }
        }
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Health")
        {
            _livesCounter++;
            _livesText.text = _livesCounter.ToString();
            Destroy(collision.gameObject);
        }
    }
}
