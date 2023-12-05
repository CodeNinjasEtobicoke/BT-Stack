using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    [Header("CO")]
    public GameObject currentCube;
    [Header("LCO")]
    public GameObject lastCube;
    [Header("TO")]
    public Text text;
    [Header("CL")]
    public int Level;
    [Header("Bool")]
    public bool Done;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void NewBlock()
    {    
        if(lastCube != null)
        {
            //currentCube.transform.position = new Vector3(Mathf.Round(currentCube.transform.position.x)),
        //currentCube.transform.position.y,
               // Mathf.Round(currentCube.transform.position.z));
           //currentCube
        }
    }
}
