using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void GamePlay ()
    {
        SceneManager.LoadScene ("playgame");
    }
    public void QuitGame()
        {
            Debug.Log("Quit!!!!!");
            Application.Quit();
        }
    
}
