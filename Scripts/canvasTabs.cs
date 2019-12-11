using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasTabs : MonoBehaviour {

    // Use this for initialization
    public GameObject GVISCanvas;
    public GameObject AeroCanvas;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GVISTab()
    {
        GVISCanvas.SetActive(true);
        AeroCanvas.SetActive(false);
    }
    public void AeroTab()
    {
        GVISCanvas.SetActive(false);
        AeroCanvas.SetActive(true);
    }
}
