using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject doll;
    public GameObject player;
    public Animator animator;
    public float blend = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = doll.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        blend += Time.deltaTime;

        if (blend < 2){

            if (blend > 0.1f)
                animator.enabled = false;
        }
        else if (blend < 17 ){
            animator.enabled = true;
        }
        else{
            player.SetActive(true);
            doll.SetActive(false);
        }

    }

}
