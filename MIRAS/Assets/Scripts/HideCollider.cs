using UnityEngine;
using UnityEngine.Tilemaps;

public class HideCollider : MonoBehaviour
{
    private TilemapRenderer tilemapRender;

    private void Awake()
    {
        tilemapRender = GetComponent<TilemapRenderer>();
    }
    void Start()
    {
         tilemapRender.enabled = false;   
    }

    
    
}
