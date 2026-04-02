using System.Collections;
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

    string CleanUp(string submission)
    {
        submission = submission.ToUpper();
        submission = submission.Trim();

        if (submission.Length >= 2)
        {
            switch (submission.Substring(0, 2)) //maybe I can do this whole thing with a dictionary, but this is good for now. 
            {
                case "DB":
                    submission = "C#" + submission.Substring(2);
                    break;
                case "EB":
                    submission = "D#" + submission.Substring(2);
                    break;
                case "GB":
                    submission = "F#" + submission.Substring(2);
                    break;
                case "AB":
                    submission = "G#" + submission.Substring(2);
                    break;
                case "BB":
                    submission = "A#" + submission.Substring(2);
                    break;
                case "CB":
                    submission = "B" + submission.Substring(2);
                    break;
                case "FB":
                    submission = "E" + submission.Substring(2);
                    break;
                case "E#":
                    submission = "F" + submission.Substring(2);
                    break;
                case "B#":
                    submission = "C" + submission.Substring(2);
                    break;
                default:
                    break;
            }

        }

        return submission;
    }


    void OnClick()
    {
        string submission = CleanUp(inputArea.text);// or maybe it's this that doesn't work
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
