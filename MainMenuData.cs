using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuData : MonoBehaviour
{

    [SerializeField] private Button newGameButton;

    // if i have ContinueButton (will be unclickable if you dont have any save of the game)

    /*private void Start()
    {
        if(!DataPersistanceManager.instance.HasGameData())
        {
            continueButton.interactable = false;
        }
    }*/
    public void OnNewGameClicked()
    {
        DisableAllButtons();
        //create a new game - which will initialize our game data
        DataPersistanceManager.instance.NewGame();
        //load the gameplay scene - which will in turn save the game because of 
        // OnSceneUnloaded() in the DataPersistenceManager
        SceneManager.LoadSceneAsync("TownScene");
    }

    public void OnContinueGameClicked()
    {
        // load the next scene - which will in turn load the game because of 
        // OnSceneLoaded() in the DatapersistanceManager
        SceneManager.LoadSceneAsync("TownScene");
    }

    private void DisableAllButtons()
    {
        newGameButton.interactable = false;
    }
}
