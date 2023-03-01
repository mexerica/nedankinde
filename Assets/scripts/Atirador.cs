using UnityEngine;

public class Atirador : MonoBehaviour {

    AudioSource audioSource;

    private float timer;

    private float timerEspecial;

    public bool deveAtirar = false;

    public bool deveEspecial = false;

    [SerializeField] private AudioClip cliptiro;
    [SerializeField] private AudioClip clipespecial;
    [SerializeField] private GameObject tiro;
    [SerializeField] private GameObject especial;

    [Range(0, 2.0f)][SerializeField] private float intervalo = 0.3f;
    [Range(0, 10.0f)][SerializeField] private float intervaloEspecial = 3f;

    void Start() {
        timer = 0;
        timerEspecial = 0;
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        timer += Time.deltaTime;
        timerEspecial += Time.deltaTime;
        if (deveAtirar && timer >= intervalo) {
            Atirar(tiro, cliptiro);
            timer = 0;
        }
        if (
            deveEspecial &&
            timerEspecial >= intervaloEspecial &&
            GetComponentInParent<Stats>().getEspecial() > 0
        ) {
            Atirar(especial, clipespecial);
            timerEspecial = 0;
            GetComponentInParent<Stats>().rmvEspecial();
        }
    }

    private GameObject Atirar(GameObject proj, AudioClip clip) {
        audioSource.PlayOneShot(clip, 0.5f);
        return Instantiate(
            proj,
            new Vector3(transform.position.x, transform.position.y, 0),
            Quaternion.identity
        );
    }

}
