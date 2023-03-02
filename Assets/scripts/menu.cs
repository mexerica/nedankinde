using UnityEngine;

public class menu : MonoBehaviour {

    [SerializeField] private GameObject protagonista;

    [SerializeField] private Sprite[] numeros = new Sprite[10];

    [SerializeField] private SpriteRenderer[] contadorVidas;

    [SerializeField] private SpriteRenderer[] contadorEspecial;

    void Start() {
        atualizaPlacar();
    }

    void Update() {
        if (protagonista != null && protagonista.GetComponent<Stats>().deveMudarInterface()) {
            atualizaPlacar();
        }
    }

    private void setaDigitos(string valor, SpriteRenderer[] contador) {
        for (int i=0; i<valor.Length; i++) {
            int v = valor[i] - '0';
            contador[i].sprite = numeros[v];
        }
    }

    private void atualizaPlacar() {
        // depois da pra separar em dois metodos aqui e só atualizar oq precisa
        int vidas = protagonista.GetComponent<Stats>().getVida();
        setaDigitos(vidas.ToString("D2"), contadorVidas);

        int especial = protagonista.GetComponent<Stats>().getEspecial();
        setaDigitos(especial.ToString("D2"), contadorEspecial);

        protagonista.GetComponent<Stats>().interfaceAtualizada();
    }

}
