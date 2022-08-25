using UnityEngine;
using UnityEngine.UI;

public class ScrBut : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private GameObject window;

    private void Start()
    {
        startButton.onClick.AddListener(StartBtnHandler);
    }

    private void StartBtnHandler()
    {
        window.SetActive(true);
        gameObject.SetActive(false);
    }
}
