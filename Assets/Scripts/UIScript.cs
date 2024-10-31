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
    }

    public void adicionarPonto()
    {
        coinCount++;
        this.textoPontuacao.text = coinCount.ToString();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log(textoPontuacao.text);
            adicionarPonto();
            Destroy(other.gameObject);

        }
    }


}