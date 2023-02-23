using UnityEngine;

/// <summary>
/// Tiro que vai em linha reta na direção especificada no atributo direcao
/// </summary>
public class Simples : Tiro {

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);
            
        transform.Translate(direcao * (Time.deltaTime / velocidade), Space.World);
        transform.Rotate(0, 0, rotacao, Space.Self);
    }
}
