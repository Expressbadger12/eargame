using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Checker : MonoBehaviour
{

    private Button button;
    public GameObject field;
    private TMP_InputField inputArea;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);

        inputArea = field.GetComponent<TMP_InputField>(); // this doesn't work?

        if (inputArea != null)
        {
            Debug.Log("We got annie"); // this doesn't trigger. We don't got annie
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClick()
    {
        string submission = inputArea.text; // or maybe it's this that doesn't work
        Debug.Log("Clicked! " + submission);
    }
}
