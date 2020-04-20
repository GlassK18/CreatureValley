using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeAssets : MonoBehaviour
{

    public static SnakeAssets instance;

    private void Awake()
    {
        instance = this;
    }



    public Sprite snakeHeadSprite;
}
