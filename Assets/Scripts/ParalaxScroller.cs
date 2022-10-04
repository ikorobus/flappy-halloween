using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxScroller : MonoBehaviour
{
    #region Parameters
    /// <summary>
    /// Speed used to move the texture
    /// </summary>
    [SerializeField]
    private float _scrollSpeed;
    /// <summary>
    /// Offset
    /// </summary>
    private Vector2 _offset;
    #endregion

    #region References
    /// <summary>
    /// Reference to own Sprite Renderer
    /// </summary>
    private SpriteRenderer _mySpriteRenderer;
    /// <summary>
    /// Reference to own Material
    /// </summary>
    private Material _myMaterial;
    #endregion
    
    #region methods
    /// <summary>
    /// Disables the component, so the texture movement stops
    /// </summary>
    private void Stop()
    {
        _mySpriteRenderer.enabled = false;
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {   // Accesses
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _myMaterial = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    { 
        // Background movement
        _offset = _scrollSpeed * Time.deltaTime * Vector2.right;
        _myMaterial.mainTextureOffset += _offset;
    }
}
