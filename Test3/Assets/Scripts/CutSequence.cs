using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSequence : MonoBehaviour

   
{
    public GameObject Cutscene_Cam;
    public GameObject CM_FreeLook;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence ()
    {
        yield return new WaitForSeconds(10);
        Cutscene_Cam.SetActive(false);
        CM_FreeLook.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
