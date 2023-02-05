using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {
    public static UIManager Instance;

    [SerializeField] private TMP_Text txtDisplay;
    

    private void Awake() {
        if (Instance != null) { Destroy(gameObject); return; }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void DisplayText(string text) {
        txtDisplay.text = text;
    }
    
}

