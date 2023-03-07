using UnityEngine;

/// <summary>
/// Tiro que pega a posicao do inimigo mais próximo quando é criado e vai naquela direção sem corrigir percurso
/// </summary>
public class TiroTrackerSimples : Tiro {

    private string tipoInimigo;

    void Start() {
        tipoInimigo = (transform.tag.Equals("TiroRuim")) ? "Bom" : "Ruim";

        GameObject maisProximo = AcharInimigoMaisProximo(tipoInimigo);
        if (maisProximo != null) {
            direcao = (maisProximo.transform.position - transform.position).normalized;
        }
    }

    private void FixedUpdate() {
        seMove();
    }

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);
            
        
    }

    private void seMove() {
        transform.Translate(direcao * (Time.deltaTime / velocidade), Space.World);
        transform.Rotate(0, 0, rotacao, Space.Self);
    }

    private GameObject AcharInimigoMaisProximo(string tagInimigo) {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(tagInimigo);

        if (gos.Length == 1)
            return gos[0];

        GameObject maisPerto = null;
        float distancia = Mathf.Infinity;
        Vector3 posicao = transform.position;
        foreach (GameObject go in gos) {
            Vector3 diff = go.transform.position - posicao;
            float curDistancia = diff.sqrMagnitude;
            if (curDistancia < distancia) {
                maisPerto = go;
                distancia = curDistancia;
            }
        }
        return maisPerto;
    }

}
