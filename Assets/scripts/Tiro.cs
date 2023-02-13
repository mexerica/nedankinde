using UnityEngine;

public class Tiro : MonoBehaviour {

    [Range(0, .5f)][SerializeField] private float velocidade = .3f;

    [SerializeField] public int dano;

    [SerializeField] private Vector3 direcao;

    [Range(0, 5f)][SerializeField] private float rotacao;

    [SerializeField] private bool isBoomerang;
    
    void Start() {
    }

    void Update() {
        transform.Translate(direcao * (Time.deltaTime / velocidade), Space.World);
        transform.Rotate(0, 0, rotacao, Space.Self);

        if (isForaDaTela())
            Destroy(gameObject);

        if (isBoomerang)
            boomerang();
    }

    private bool isForaDaTela() {
        return transform.position.x > 3.0f
            || transform.position.x < -5.0f
            || transform.position.y > 4.0f
            || transform.position.y < -4.0f;
    }

    private void boomerang() {
        if (transform.position.y >= 2.5f)
            direcao.y = direcao.y * -1;
    }

}
