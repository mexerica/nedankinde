using UnityEngine;

public class Atirador : MonoBehaviour {

    AudioSource audioSource;
    private AudioClip clip;

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
        if (audioSource == null) audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update() {
        timer += Time.deltaTime;
        timerEspecial += Time.deltaTime;
        if (deveAtirar && timer >= intervalo) {
            clip = cliptiro;
            Atirar(tiro);
            timer = 0;
        }
        if (
            deveEspecial &&
            timerEspecial >= intervaloEspecial &&
            GetComponentInParent<Stats>().especial > 0
        ) {
            clip = clipespecial;
            Atirar(especial);
            timerEspecial = 0;
            GetComponentInParent<Stats>().especial --;
        }
    }

    private GameObject Atirar(GameObject proj) {
        audioSource.PlayOneShot(clip, 0.5f);
        return Instantiate(
            proj,
            new Vector3(transform.position.x, transform.position.y, 0),
            Quaternion.identity
        );
    }

}
