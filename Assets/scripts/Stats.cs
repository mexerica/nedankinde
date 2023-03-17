using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Stats : MonoBehaviour {

    /// <summary>
    /// Pra protagonista vai de 0 a 99, 0 quer dizer q vc morreu :(
    /// </summary>
    [SerializeField] private int vida = 4;

    /// <summary>
    /// Pra protagonista vai de 0 a 99, pra add mais precisa mudar o jeito q esse valor é exibido na interface
    /// </summary>
    [SerializeField] private int especial = 2;

    [SerializeField] private bool isVilao;

    private string tipoInimigo;

    /// <summary>
    /// Usado pela protagonista pra sinalizar que a interface precisa ser atualizada com novos valores
    /// </summary>
    private bool mudarInterface = true;

    public GameObject GameOver;

    void Start() {
        tipoInimigo = (isVilao ? "TiroBom" : "TiroRuim");
    }

    void Update() {
        if (vida <= 0) {
            if (isVilao) {
                transform.GetComponent<inimigo>().dropaLoot();
            } else {
                //game over
                GameOver.SetActive(true);
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag.Equals(tipoInimigo)) {
            rmvVida(collision.GetComponent<Tiro>().dano);
        } else if (collision.gameObject.tag.Equals("Poder") && !isVilao) {
            collision.GetComponent<Poder>().coletar(this);
        }
    }

    public int getEspecial() {
        return especial;
    }

    public void addEspecial(int especial) {
        especial += especial;
        if (especial >= 99)
            especial = 99;
        if (!isVilao)
            mudarInterface = true;
    }

    public void rmvEspecial() {
        if (especial > 0)
            especial -= 1;
        if (!isVilao)
            mudarInterface = true;
    }

    public int getVida() {
        return vida;
    }

    public void addVida() {
        if (vida < 99)
            vida += 1;
        if (!isVilao)
            mudarInterface = true;
    }

    public void rmvVida(int vida) {
        this.vida -= vida;

        if (this.vida < 0)
            this.vida = 0;
        if (!isVilao)
            mudarInterface = true;
    }

    public bool deveMudarInterface() {
        return mudarInterface;
    }

    public void interfaceAtualizada() {
        mudarInterface = false;
    }
    
}
