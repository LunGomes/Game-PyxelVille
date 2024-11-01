using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
     private UIScript pontuacao;

     private void Start(){
		pontuacao = GameObject.FindObjectOfType<UIScript>();
	}

     private void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag("Player"))
		{
			
			Destroy(gameObject);
			pontuacao.AdicionarPonto();
		}
    }
}
