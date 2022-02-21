using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSequence : MonoBehaviour

   
{
    public GameObject CutsceneCam;
    public GameObject Main_Camera;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence ()
    {
        yield return new WaitForSeconds(10);
        Main_Camera.SetActive(true);
        CutsceneCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
