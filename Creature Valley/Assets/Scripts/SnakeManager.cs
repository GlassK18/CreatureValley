using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;
public class SnakeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject snakeHeadGameObject = new GameObject();
        SpriteRenderer snakeSpriteRenderer = snakeHeadGameObject.AddComponent<SpriteRenderer>();
        snakeSpriteRenderer.sprite = SnakeAssets.instance.snakeHeadSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
