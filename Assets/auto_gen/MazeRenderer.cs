﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRenderer : MonoBehaviour
{

    [SerializeField]
    [Range(1, 50)]
    private int width = 10;

    [SerializeField]
    [Range(1, 50)]
    private int height = 10;

    [SerializeField]
    private float size = 1f;

    [SerializeField]
    private Transform wallPrefab = null;

    [SerializeField]
    private Transform floorPrefab = null;
    [SerializeField]
    private int mazeSeed = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (mazeSeed==0)
        {
            mazeSeed =Random.Range(0,10000);
        }
        var maze = MazeGenerator.Generate(width, height,seed:mazeSeed);
        Draw(maze);
        // gameObject.transform.Rotate(-90f,0f,0f);
    }

    private void Draw(WallState[,] maze)
    {

        var floor = Instantiate(floorPrefab, transform);
        floor.localScale = new Vector2(width,  height);   
        for (int i = 0; i < width; ++i)
        {
            for (int j = 0; j < height; ++j)
            {
                var cell = maze[i, j];
                var position = new Vector2(-width / 2 + i, -height / 2 + j);

                if (cell.HasFlag(WallState.UP))
                {
                    var topWall = Instantiate(wallPrefab, transform) as Transform;
                    topWall.position = position + new Vector2(0, size / 2);
                    topWall.localScale = new Vector2( topWall.localScale.x*size, topWall.localScale.y*size);
                }

                if (cell.HasFlag(WallState.LEFT))
                {
                    var leftWall = Instantiate(wallPrefab, transform) as Transform;
                    leftWall.position = position + new Vector2(-size / 2,  0);
                    leftWall.localScale = new Vector2( leftWall.localScale.x*size, leftWall.localScale.y*size);
                    leftWall.eulerAngles = new Vector3(0, 0, 0);
                }

                if (i == width - 1)
                {
                    if (cell.HasFlag(WallState.RIGHT))
                    {
                        var rightWall = Instantiate(wallPrefab, transform) as Transform;
                        rightWall.position = position + new Vector2(+size / 2,  0);
                        rightWall.localScale = new Vector2( rightWall.localScale.x*size, rightWall.localScale.y*size);
                        rightWall.eulerAngles = new Vector3(0,0 , 0);
                    }
                }

                if (j == 0)
                {
                    if (cell.HasFlag(WallState.DOWN))
                    {
                        var bottomWall = Instantiate(wallPrefab, transform) as Transform;
                        bottomWall.position = position + new Vector2(0,  -size / 2);
                        bottomWall.localScale = new Vector2( bottomWall.localScale.x*size, bottomWall.localScale.y*size);
                    }
                }
            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}