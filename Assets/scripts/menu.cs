using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

    [SerializeField] private GameObject protagonista;

    [SerializeField] private Sprite[] numeros = new Sprite[10];

    [SerializeField] private SpriteRenderer contadorVidas;

    [SerializeField] private SpriteRenderer contadorEspecial;

    void Start() {

    }

    void Update() {
        contadorVidas.sprite = numeros[protagonista.GetComponent<Vida>().vida];
    }
}
