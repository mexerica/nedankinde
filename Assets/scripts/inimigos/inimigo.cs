using UnityEngine;

public class inimigo : MonoBehaviour {

    [Range(0, 5f)][SerializeField] protected float velocidade = 1f;

    [Range(0, 1000)][SerializeField] protected int valor = 1;

    [SerializeField] private GameObject poderVida;
    [Range(0, 100)][SerializeField] protected int chanceDropVida = 0;

    [SerializeField] private GameObject poderEspecial;
    [Range(0, 100)][SerializeField] protected int chanceDropEspecial = 0;

    GameObject menu;

    protected Rigidbody2D body;

    void Awake() {
        menu = GameObject.FindGameObjectWithTag("Menu");
    }

    protected bool isForaDaTela() {
        return transform.position.y < -6.0f
            || transform.position.y > 6.0f
            || transform.position.x < -7.0f
            || transform.position.x > 5.0f;
    }

    public void dropaLoot() {
        GameObject loot = escolheLoot();
        if (loot != null) {
            Instantiate(
                loot,
                new Vector3(transform.position.x, transform.position.y, 0),
                Quaternion.identity
            );
        }

        //icrementa o score
        menu.GetComponent<menu>().setScore(valor);
    }

    private GameObject escolheLoot() {
        int aleatorio = Random.Range(1, 101);
        if (aleatorio <= chanceDropVida)
            return poderVida;

        aleatorio = Random.Range(1, 101);
        if (aleatorio <= chanceDropEspecial)
            return poderEspecial;

        return null;
    }
}
