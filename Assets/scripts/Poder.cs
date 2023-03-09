using UnityEngine;

public class Poder : MonoBehaviour {

    private Vector3 posInicial;
    private Vector3 posControle;
    private Vector3 posFinal;

    private float cont = 0.0f;

    [Range(0, 5f)][SerializeField] protected float velocidade = 1f;

    [Range(0, 5f)][SerializeField] protected float rotacao;

    [SerializeField] private bool vida = false;

    [SerializeField] private int especial = 0;

    void Start() {
        posInicial = transform.position;
        posControle = new Vector3(transform.position.x, transform.position.y+1f, 0);
        posFinal = new Vector3(transform.position.x, -5.0f, 0);
    }

    private void FixedUpdate() {
        seMove();
    }

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);
    }

    private bool isForaDaTela() {
        return transform.position.y < -4.0f
            || transform.position.y > 4.0f
            || transform.position.x < -5.0f
            || transform.position.x > 3.0f;
    }

    public void coletar(Stats stats) {
        if (vida) {
            stats.addVida();
        } if (especial != 0) {
            stats.addEspecial(especial);
        }
        Destroy(gameObject);
    }

    private void seMove() {
        if (cont < 1)
            cont += velocidade * Time.deltaTime;

        Vector3 m1 = Vector3.Lerp( posInicial, posControle, cont );
        Vector3 m2 = Vector3.Lerp( posControle, posFinal, cont );
        transform.position = Vector3.Lerp(m1, m2, cont);
        
        transform.Rotate(0, 0, rotacao, Space.Self);
    }

}
