using UnityEngine;

public class Tiro : MonoBehaviour {

    [SerializeField] protected Vector3 direcao;
    
    [Range(0, .5f)][SerializeField] protected float velocidade = .3f;

    [SerializeField] public int dano;

    [Range(0, 5f)][SerializeField] protected float rotacao;
    
    void Start() {
        
    }

    protected bool isForaDaTela() {
        return transform.position.y < -4.0f
            || transform.position.y > 4.0f
            || transform.position.x < -5.0f
            || transform.position.x > 3.0f;
    }

}
