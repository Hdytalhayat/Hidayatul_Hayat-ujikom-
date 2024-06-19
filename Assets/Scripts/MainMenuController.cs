using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]private Button playbtn;
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
        SceneManager.LoadScene("SampleScene");
    }
}
