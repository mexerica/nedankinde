using UnityEngine;

public class Tiro : MonoBehaviour {

    [Range(0, .5f)][SerializeField] private float velocidade = .3f;
    
    void Start() {
    }

    void Update() {
        transform.Translate(Vector3.up * (Time.deltaTime / velocidade), Space.World);
        if (isForaDaTela()) Destroy(gameObject);
    }

    private bool isForaDaTela() {
        return transform.position.x > 3.0f
            || transform.position.x < -5.0f
            || transform.position.y > 4.0f
            || transform.position.y < -4.0f;
    }
}
