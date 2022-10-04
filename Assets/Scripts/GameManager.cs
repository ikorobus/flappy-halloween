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

    #region properties
    /// <summary>
    /// True if the Game is running, False otherwise
    /// </summary>
    private bool _isGameRunning;
    /// <summary>
    /// Accesor to get the state of the game
    /// </summary>
    public bool IsGameRunning
    {
        get
        {
            return _isGameRunning;
        }
    }
    #endregion

    #region methods
    /// <summary>
    /// Method to send message Jump to player
    /// </summary>
    private void Jump()
    {
        Debug.Log("Mensaje recibido en GameManager.");
        _player.SendMessage("Jump");
    }
    /// <summary>
    /// Method to manage finalization of the game
    /// </summary>
    private void OnPlayerDies()
    {
        //TODO
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}