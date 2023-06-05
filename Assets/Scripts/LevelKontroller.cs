using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelKontroller : MonoBehaviour
{
    public static LevelKontroller instance;
    private void Awake()
    {
        instance = this;
    }
    public GameObject[] levels = new GameObject[0];
    int index = 0;

    public void NextLevel()
    {
        levels[index % levels.Length].SetActive(false);
        index++;
        levels[index % levels.Length].SetActive(true);

    }


}
