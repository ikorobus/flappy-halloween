using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    #region references
    /// <summary>
    /// Array of prefabs to instantiate as obstacles
    /// </summary>
    [SerializeField]
    private GameObject[] _prefabs;
    /// <summary>
    /// Reference to transform where obstacles will be instantiated
    /// </summary>
    [SerializeField]
    private Transform _spawnTransform;
    #endregion

    #region paramaters
    /// <summary>
    /// Maximum time between obstacles generation
    /// </summary>
    [SerializeField]
    private float _maxTimeInterval = 5.0f;
    /// <summary>
    /// Minimum time between obstacles generation
    /// </summary>
    [SerializeField]
    private float _minTimeInterval = 1.0f;

    private int _count;
    #endregion

    #region properties
    /// <summary>
    /// Elapsed time since last obstacle generation
    /// </summary>
    private float _elapsedTime;
    /// <summary>
    /// Time interval set for next obstacle generation
    /// </summary>
    private float _nextSpawnTime = 2.0f;
    #endregion

    #region methods
    /// <summary>
    /// Method to disable the script and thus stop obsctacles generation
    /// </summary>
    private void Stop()
    {
        
        var clones = GameObject.FindGameObjectsWithTag("Clone");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
        //Destroy(GameObject.FindWithTag("Clone"));
        Debug.Log("Generación de obstáculos parada.");
        Behaviour.Destroy(this);
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _nextSpawnTime) 
        {
            Instantiate(_prefabs[Random.Range(0, _prefabs.Length)], _spawnTransform.position, Quaternion.identity);
            _elapsedTime = 0.0f;
            _nextSpawnTime = Random.Range(_minTimeInterval, _maxTimeInterval);
            Debug.Log("Obstáculo instanciado.");
        }
    }
}
