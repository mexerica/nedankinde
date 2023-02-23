using UnityEngine;

public class menu : MonoBehaviour {

    [SerializeField] private GameObject protagonista;

    [SerializeField] private Sprite[] numeros = new Sprite[10];

    [SerializeField] private SpriteRenderer contadorVidas;

    [SerializeField] private SpriteRenderer contadorEspecial;

    void Start() {

    }

    void Update() {
        if (protagonista != null) {
            contadorVidas.sprite = numeros[protagonista.GetComponent<Stats>().vida];
            contadorEspecial.sprite = numeros[protagonista.GetComponent<Stats>().especial];
        }
    }
}
