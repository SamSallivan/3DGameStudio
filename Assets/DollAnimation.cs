using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollAnimation : MonoBehaviour
{
    
    public GameObject doll;
    public Animator animator;
    public float blend = 0;
    public bool swing = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = doll.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (blend < 1 && swing){
            blend += 0.01f;
        }
        if (blend > 0 && !swing){
            blend -= 0.01f;
        }

        animator.SetFloat("Blend", blend);
    }

    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            //animator.SetFloat("Blend", 1);
            //animator.Play("SitIdle");
            //animator.SetBool("Swing", false);
            swing = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            //animator.SetFloat("Blend", 0);
            //animator.Play("SitSwing");
            //animator.SetBool("Swing", true);
            swing = true;
        }

    }

    IEnumerator Swing(){
        yield return null;
    }
}
