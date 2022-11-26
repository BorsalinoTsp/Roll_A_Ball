using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    
    public TextMeshProUGUI coinText;

    public float speed = 4f;
    
    Rigidbody RigidBody_; 

    public GameObject GameOverPanel;


    

    void Start() 
    {
        RigidBody_ = GetComponent<Rigidbody>();
        Time.timeScale = 1;
        score.coin = 0;
       
    }
    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);
        RigidBody_.AddForce(movement * speed);
    
        coinText.text = score.coin.ToString();

        if(score.coin == 5)
        {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;

        }




    }
    public void RestartGame_()
    {
        
        GameOverPanel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        

    }

    
}
