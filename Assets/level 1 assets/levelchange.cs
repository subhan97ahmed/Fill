﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelchange : MonoBehaviour
{
    // Start is called before the first frame update
    public int number_of_particle_required =14;
    public int number_of_particle_entered=0;
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Particle")){
        number_of_particle_entered++;
        UnityEngine.Object.Destroy(other.gameObject);
        audioSource.Play();
        }
        if(number_of_particle_required<number_of_particle_entered){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Time.timeScale = 1;
        }
        
    }
}
