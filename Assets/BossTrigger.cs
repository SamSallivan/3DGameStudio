using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    public GameObject fogWall;
    public GameObject ui;
    public GameObject vordt;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vordt.activeInHierarchy)
            vordt.transform.position += new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.15f, 0.15f), Random.Range(-0.2f, 0.2f));
            vordt.transform.localScale = new Vector3(Random.Range(0.8f, 1.2f), Random.Range(0.8f, 1.2f), Random.Range(0.8f, 1.2f));
        
        
    }
    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player" && !fogWall.activeInHierarchy){
            fogWall.SetActive(true);
            ui.SetActive(true);
            vordt.SetActive(true);
            audioSource.Play();
        }
    }

}

