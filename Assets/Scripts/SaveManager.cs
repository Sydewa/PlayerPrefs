using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public string userName;
    public int userScore;
    public Vector3 userPosition;

    public Text nameText;
    public Text scoreText;
    public Text positionText;

    void Start()
    {
        LoadData();
    }

    void LoadData()
    {
        nameText.text = "Your name is: " + PlayerPrefs.GetString("name", "Your mom!");
        scoreText.text = "Your score is " + PlayerPrefs.GetInt("score", 0).ToString() + "!";
        positionText.text = "Your position is: " + PlayerPrefs.GetFloat("posX", 0).ToString() + "x, " + PlayerPrefs.GetFloat("posY", 0).ToString() + "y, " + PlayerPrefs.GetFloat("posZ", 0).ToString() + "z.";
    }

    void SaveData()
    {
        PlayerPrefs.SetString("name", userName);
        PlayerPrefs.SetInt("score", userScore);
        PlayerPrefs.SetFloat("posX", userPosition.x);
        PlayerPrefs.SetFloat("posY", userPosition.y);
        PlayerPrefs.SetFloat("posZ", userPosition.z);
    }

    void DelteData()
    {

    }
}
