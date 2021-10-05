using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeOnGreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Color greenColor;
    public bool[] count;
    public GameObject[] dots;
    public SpriteRenderer[] spriteRenderers;

    void Start()
    {
        for (int i = 0; i < dots.Length; i++)
        {
            spriteRenderers[i] = dots[i].gameObject.GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        ChangeLevelWhenAllDotsrGreen();

    }
    void ChangeLevelWhenAllDotsrGreen()
    {
        for (int i = 0; i < dots.Length; i++)
        {
            if ((int)(dots[i].GetComponent<SpriteRenderer>().color.r * 1000) == (int)(greenColor.r * 1000))
            {
                count[i] = true;

            }
        }
        int countnum = 0;
        for (int i = 0; i < count.Length; i++)
        {

            if (count[i] == true)
            {
                countnum++;
            }
        }
        if (countnum >= 7)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Time.timeScale = 1;
        }

    }
}
