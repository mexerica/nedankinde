using UnityEngine;

public class Boomerang : Tiro {

    public bool isVoltando = false;

    void Start() {
        
    }

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);

        if (transform.position.y >= 2.5f) {
            direcao.y = direcao.y * -1;
            transform.position = new Vector3(transform.position.x, 2.45f, transform.position.z);
            isVoltando = true;
        }
        transform.Translate(direcao * (Time.deltaTime / velocidade), Space.World);
        transform.Rotate(0, 0, rotacao, Space.Self);
    }
}
