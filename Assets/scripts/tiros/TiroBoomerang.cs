using UnityEngine;

/// <summary>
/// Tiro que vai até o limite superior da tela e volta em linha reta
/// </summary>
public class TiroBoomerang : Tiro {

    public bool isVoltando = false;

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
