using UnityEngine;

public class ArcoCima : inimigo {

    private Vector3 posInicial;
    private Vector3 posFinal;

    [SerializeField]
    private Vector3 posControle = new Vector3(0, -2.5f, 0);

    private float cont = 0.0f;

    void Start() {
        posInicial = transform.position;
        posFinal = new Vector3(transform.position.x*(-1), transform.position.y, 0);
        //posControle = posInicial +(posFinal - posInicial)/2 + Vector3.up *5.0f;
    }

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);

        if (transform.position.Equals(posFinal))
            Destroy(gameObject);

        if (cont < velocidade) {
            cont += velocidade *Time.deltaTime;

        Vector3 m1 = Vector3.Lerp( posInicial, posControle, cont );
        Vector3 m2 = Vector3.Lerp( posControle, posFinal, cont );
        transform.position = Vector3.Lerp(m1, m2, cont);
    }
    }

}
