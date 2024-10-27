using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    
    void Start()
    {
        var button = GetComponent<Button>();
        
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Tennis Mobile/Scenes/Game scene");
        });
    }

}
