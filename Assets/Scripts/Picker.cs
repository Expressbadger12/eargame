using UnityEngine;

public class Picker : MonoBehaviour
{

    AudioSource player;
    private AudioClip[] notes;
    public AudioClip mystery;

    void Awake()
    {
        player = GetComponent<AudioSource>();
    }
    void Start()
    {
        notes = Resources.LoadAll<AudioClip>("audio"); // It works!
        
        PickSound();
    }

    void PickSound()
    {
        int choice = UnityEngine.Random.Range(0, notes.Length);

        Debug.Log(notes.Length);

        player.clip = notes[choice];

        mystery = notes[choice];
    }

    //https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Resources.LoadAll.html 
    //https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Resources.html
    //https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Resources.Load.html

    void Update()
    {
        
    }
}
