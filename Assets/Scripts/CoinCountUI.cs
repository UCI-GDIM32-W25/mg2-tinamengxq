using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class CoinCountUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text _coinText;

    public void UpdateCoin(int coinEaten)
    {
        _coinText.text = "Points:" + coinEaten;
    }
}
