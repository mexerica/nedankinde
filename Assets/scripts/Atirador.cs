using UnityEngine;

public class Atirador : MonoBehaviour {

    private float timer;

    private float timerEspecial;

    public bool deveAtirar = false;

    public bool deveEspecial = false;

    [SerializeField] private GameObject tiro;
    [SerializeField] private GameObject especial;

    [Range(0, 1.0f)][SerializeField] private float intervalo = 0.3f;
    [Range(0, 10.0f)][SerializeField] private float intervaloEspecial = 3f;

    void Start() {
        timer = 0;
        timerEspecial = 0;
    }

    void Update() {
        timer += Time.deltaTime;
        timerEspecial += Time.deltaTime;
        if (deveAtirar && timer >= intervalo) {
            Atirar(tiro);
            timer = 0;
        }
        if (deveEspecial && timerEspecial >= intervaloEspecial) {
            Atirar(especial);
            timerEspecial = 0;
        }
    }

    private GameObject Atirar(GameObject proj) {
        return Instantiate(
            proj,
            new Vector3(transform.position.x, transform.position.y, 0),
            Quaternion.identity
        );
    }

}
