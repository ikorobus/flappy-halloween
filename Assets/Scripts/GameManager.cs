using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region References
    /// <summary>
    /// Reference to player
    /// </summary>
    [SerializeField]
    private GameObject _player;
    /// <summary>
    /// Reference to UI Manager
    /// </summary>
    [SerializeField]
    private GameObject _UIManager;
    /// <summary>
    /// Reference to Level Manager
    /// </summary>
    [SerializeField]
    private GameObject _levelManager;
    #endregion

    #region methods
    /// <summary>
    /// Method to send message Jump to player
    /// </summary>
    private void Jump()
    {
        _player.SendMessage("Jump");
    }
    /// <summary>
    /// Method to manage finalization of the game
    /// </summary>
    private void OnPlayerDies()
    {
        SendMessage("GameOver");
        SendMessage("Stop");
        GetComponent<InputComponent>().enabled = false;
        _levelManager.SendMessage("GameOver");
    }
    #endregion
}
