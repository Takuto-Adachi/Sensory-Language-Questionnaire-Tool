using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void A1StartButton()
    {
        Debug.Log("A_1 start");
        SceneManager.LoadScene("A-1");
    }

    public void A2StartButton()
    {
        Debug.Log("A_2 start");
        SceneManager.LoadScene("A-2");
    }
    
    public void BStartButton()
    {
        Debug.Log("B start");
        SceneManager.LoadScene("B-title");
    }
}
