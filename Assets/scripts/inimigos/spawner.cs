using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    [Range(0, 10)][SerializeField] private float espera = 2;

    [SerializeField] private List<Wave> waves;

    private Wave waveAtual;

    private float timer;

    private int indice = 0;

    private float intervalo;

    private bool terminouWave = true;

    void Start() {
    }

    void Update() {
        if (indice < waves.Count && terminouWave) {
            if (timer > espera) {
                waveAtual = waves[indice];
                espera = waveAtual.duracao;
                
                indice++;
                timer = 0;

                SpawnWave();
            } else
                timer += Time.deltaTime;
        }
    }

    private void SpawnWave() {
        //TODO: achar um jeito de retornar os inimigos? não precisa
        terminouWave = false;
        intervalo = waveAtual.intervalo;
        for (int i=1; i<=waveAtual.quantidade; i++) {
            StartCoroutine(SpawnInimigo(i==waveAtual.quantidade, intervalo));
            intervalo += waveAtual.intervalo;
        }
    }

    private IEnumerator SpawnInimigo(bool ultimo, float intervalo) {
        yield return new WaitForSeconds(intervalo);
        terminouWave = ultimo;
        Vector3 posRelativa = waveAtual.posicao;
        Instantiate(waveAtual.inimigo, posRelativa, Quaternion.identity);
        Debug.Log(terminouWave);
    }
}
