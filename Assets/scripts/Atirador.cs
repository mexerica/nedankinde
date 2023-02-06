using UnityEngine;

public class Atirador : MonoBehaviour {

    private float timer;

    public bool deveAtirar = false;

    [SerializeField] private GameObject tiro;

    [Range(0, 1.0f)][SerializeField] private float intervalo = 0.3f;

    void Start() {
        timer = 0;
    }

    void Update() {
        timer += Time.deltaTime;
        if (deveAtirar)
            Spawn();
    }

    private void Spawn() {
        if (timer >= intervalo) {
            GameObject proj = Instantiate(tiro, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            timer = 0;
        }
    }

}
