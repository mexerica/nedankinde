using UnityEngine;

public class Poder : MonoBehaviour {

    [SerializeField] private bool vida = false;

    [SerializeField] private int especial = 0;

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);
    }

    private bool isForaDaTela() {
        return transform.position.x > 3.0f
            || transform.position.x < -5.0f
            || transform.position.y > 4.0f
            || transform.position.y < -4.0f;
    }

    public void coletar(Stats stats) {
        if (vida) {
            stats.addVida();
        } if (especial != 0) {
            stats.addEspecial(especial);
        }
        Destroy(gameObject);
    }

}
