using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audioscript : MonoBehaviour
{  
    public static AudioSource audioSource;
    public AudioClip collect;
    public AudioClip die;
    //public AudioClip stageStart;
    //public AudioClip gameOver;
    //public AudioClip stageClear;
    //public AudioClip intro;
    //ublic AudioClip littleTime;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }
    public void Collect(){
        audioSource.clip = collect;
    }
    public void Die(){
        audioSource.clip = die;
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
