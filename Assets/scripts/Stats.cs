using UnityEngine;

public class Stats : MonoBehaviour {
    [SerializeField] public int vida = 4;

    [SerializeField] public int especial = 2;

    [SerializeField] private bool isVilao;

    private string tipoInimigo;

    void Start() {
        tipoInimigo = (isVilao ? "TiroBom" : "TiroRuim");
    }

    void Update() {
        if (vida <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == tipoInimigo) {
            vida -= collision.GetComponent<Tiro>().dano;
        }
    }
    
}
