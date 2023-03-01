using UnityEngine;

public class menu : MonoBehaviour {

    [SerializeField] private GameObject protagonista;

    [SerializeField] private Sprite[] numeros = new Sprite[10];

    [SerializeField] private SpriteRenderer[] contadorVidas;

    [SerializeField] private SpriteRenderer[] contadorEspecial;

    void Start() {
        int vidas = protagonista.GetComponent<Stats>().getVida();
        int especial = protagonista.GetComponent<Stats>().getEspecial();

        separaDigitos(vidas, contadorVidas, 0);
        separaDigitos(especial, contadorEspecial, 0);

        protagonista.GetComponent<Stats>().interfaceAtualizada();
    }

    void Update() {
        if (protagonista != null && protagonista.GetComponent<Stats>().deveMudarInterface()) {
            int vidas = protagonista.GetComponent<Stats>().getVida();
            int especial = protagonista.GetComponent<Stats>().getEspecial();

            separaDigitos(vidas, contadorVidas, 0);
            separaDigitos(especial, contadorEspecial, 0);
            
            protagonista.GetComponent<Stats>().interfaceAtualizada();
        }
            
    }

    /// <summary>
    /// Ta errado isso aqui, ele ignora valores com mais digitos, vou mudar depois
    /// </summary>
    private void separaDigitos(int valor, SpriteRenderer[] contador, int indice) {

        contador[indice].sprite = numeros[valor%10];

        if (valor < 10)
            return;

        separaDigitos(valor / 10, contador, indice+1);
        
    }

}
