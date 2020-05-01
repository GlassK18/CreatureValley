using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;
public class SnakeManager : MonoBehaviour
{
    [SerializeField] private Snake snake;
    private LevelGrid levelGrid;

    // Start is called before the first frame update
   public void Start()
    {
        levelGrid = new LevelGrid(20, 20);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);

      
    }

   
}
