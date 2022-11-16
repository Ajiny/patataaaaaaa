using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{   
    public static void gameOver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        //GameOverScreen.Setup();
    }

    public void QuitGame(){

        Debug.Log("Quit Game");
        Application.Quit();
    }
    
    //public Text pointsText;
    //public static void Setup(){
        //gameObject.SetActive(true);
        //pointsText.score.Tostring() + " potatoes saved"
    //}
}
 