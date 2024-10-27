using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkkinButton : MonoBehaviour
{
    
    void Start()
    {
        var button = GetComponent<Button>();
        
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Player shop");
        });
    }

}
