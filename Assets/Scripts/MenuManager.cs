using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    //ENCAPSULATION
    // Public
    public static MenuManager Instance { get; private set; }
    public static string Name { get; private set; }

    // Private
    [SerializeField] private TMP_InputField InputField;

    public void GoToSimulation()
    {
        Name = InputField.text;
        if (Name != null && Name != "") SceneManager.LoadScene("Game");
    }
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
