using UnityEngine;

public class inimigo : MonoBehaviour {

    [Range(0, 5f)][SerializeField] protected float velocidade = 1f;

    [SerializeField] private GameObject poderVida;
    [Range(0, 100)][SerializeField] protected int chanceDropVida = 0;

    [SerializeField] private GameObject poderEspecial;
    [Range(0, 100)][SerializeField] protected int chanceDropEspecial = 0;

    protected Rigidbody2D body;

    protected bool isForaDaTela() {
        return transform.position.x > 5.0f
            || transform.position.x < -7.0f
            || transform.position.y > 6.0f
            || transform.position.y < -6.0f;
    }

    public GameObject dropaLoot() {
        int aleatorio = Random.Range(1, 101);
        if (aleatorio <= chanceDropVida) {
            return Instantiate(
                poderVida,
                new Vector3(transform.position.x, transform.position.y, 0),
                Quaternion.identity
            );
        } else {
            aleatorio = Random.Range(1, 101);
            if (aleatorio <= chanceDropEspecial) {
                return Instantiate(
                    poderEspecial,
                    new Vector3(transform.position.x, transform.position.y, 0),
                    Quaternion.identity
                );
            }
        }
        
        return null;
    }
}
