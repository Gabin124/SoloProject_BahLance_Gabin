using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartZeGame()
 {
     SceneManager.LoadScene("Game");   //permet de charger la scene "Map"
 }
    public void QuitGame()
 {
     Application.Quit();      // permet de quitter le jeu
      Debug.Log("EXIT GAME");
 }
}