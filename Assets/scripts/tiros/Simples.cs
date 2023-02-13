using UnityEngine;

public class Simples : Tiro {

    void Start() {
        
    }

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);
            
        transform.Translate(direcao * (Time.deltaTime / velocidade), Space.World);
        transform.Rotate(0, 0, rotacao, Space.Self);
    }
}
