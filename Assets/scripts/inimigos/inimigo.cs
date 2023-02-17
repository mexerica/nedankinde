using UnityEngine;

public class inimigo : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        
    }

    protected bool isForaDaTela() {
        return transform.position.x > 5.0f
            || transform.position.x < -7.0f
            || transform.position.y > 6.0f
            || transform.position.y < -6.0f;
    }
}
