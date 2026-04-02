using TMPro;
using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.UI;

public class Checker : MonoBehaviour
{

    private Button button;
    public GameObject field;
    private TMP_InputField inputArea;

    private Picker picker;
    public GameObject playButton;

    public GameObject confetti;

    private ParticleSystem particle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);

        inputArea = field.GetComponent<TMP_InputField>(); 

        picker = playButton.GetComponent<Picker>();

        particle = confetti.GetComponent<ParticleSystem>();

        //debug studd don't sweat it

        //its just to prove that i succesfully gave input area a value (which I did)

        //if (inputArea != null)
        //{

            
        //    Debug.Log("We got annie");

        //    Debug.Log(picker.mystery);
        //}
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClick()
    {
        string submission = inputArea.text; // or maybe it's this that doesn't work
                                            //  Debug.Log("Clicked! " + submission);
                                            //Debug.Log(picker.mystery);

        string answer = picker.mystery.name;

        if (submission == answer)
        {
            Debug.Log("Correct!");

            particle.Play();

            picker.PickSound();
            
        } else
        {
            Debug.Log("wrong!");
        }
    }
}
