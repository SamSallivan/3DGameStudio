using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager staticInstance;

    public float points = 0;
    public GameObject gate;
    [SerializeField] TMP_Text text;
    //public TextMeshPro textDisplay;
    private void Start()
    {
        // Set the static instance to this instance
        staticInstance = this;
        //textDisplay = tmp.GetComponent<TextMeshPro>();
    }

    private void Update() {

        if(points>=11){
            gate.SetActive(false);
            text.text="";
        }
        else{
            
            text.text = points + "/11";
        }
    }
    public static GameManager Instance
    {
        get
        {
            // If the static instance isn't set yet, throw an error
            if (staticInstance is null)
            {
                Debug.LogError("Game Manager is NULL");
            }

            return staticInstance;
        }
    }

}
