using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    
    public GameObject light;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = light.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
    
    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player"){
            if(!light.activeInHierarchy){
                light.SetActive(true);
                GameManager.Instance.points++;
                audioSource.Play();
            }
        }

    }

    void OnTriggerExit(Collider other)
    {

    }
}
