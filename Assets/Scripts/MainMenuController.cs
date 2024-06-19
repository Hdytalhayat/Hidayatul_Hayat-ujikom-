using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]private Button playbtn;
    [SerializeField]private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        playbtn.onClick.AddListener(PlayButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton()
    {
        audioSource.Play();
        SceneManager.LoadScene("SampleScene");
    }
}
