using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGoal : MonoBehaviour
{
    public GameObject clearTest;
    public GameObject nextButton;
    public AudioSource audioSource;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        clearTest.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
