using Unity.VisualScripting;
using UnityEditor.AssetImporters;
using UnityEngine;

public class Playsound : MonoBehaviour
{

    CircleCollider2D skin;
    AudioSource mouth;

    void Awake()
    {
        skin = GetComponent<CircleCollider2D>();
        mouth = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundGo()
    {
        mouth.Play();
    }

    //void onTrigger(
}
