using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
//using TMPro.EditorUtilities;
using UnityEngine;

public class CoinCountUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text _coinText;
    private int score;

    void Start()
    {
        _coinText.text = "Score: 0";
    }

    //Add score when eating a coin
    public void EatACoin()
    {
        score += 1;
        UpdateCoin();
    }
    //Update UI
    void UpdateCoin()
    {
        _coinText.text = "Score: " + score;
    }
}
