using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatics : MonoBehaviour
{
    public float MaxHP;
    public float CurrentHP;
    public Text currentHPText;
    float convertfloat;
    public float points;
    public Text pointsText;
    float convertpointsfloat;
    

    // Start is called before the first frame update
    void Start()
    {
        CurrentHP = MaxHP;
    }
    private void Update()
    {
        if (CurrentHP <= 0)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("Level1");
        }
        
        currentHPText.text = convertfloat.ToString();
        convertfloat = CurrentHP;

        pointsText.text = convertpointsfloat.ToString();
        convertpointsfloat = points;


    }

    

}
