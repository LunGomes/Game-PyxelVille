using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIScript : MonoBehaviour
{
    private Label textoPontuacao;
    public int coinCount;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");
        Debug.Log("Start method called. Initial Label text: " + textoPontuacao.text);
    }

    public void AdicionarPonto()
    {
            Debug.Log("AdicionarPonto method called. Current coinCount: " + coinCount);
            coinCount++;
            textoPontuacao.text = coinCount.ToString();
            Debug.Log("Label text updated to: " + textoPontuacao.text);
    }


}