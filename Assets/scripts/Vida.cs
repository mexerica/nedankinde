using UnityEngine;

public class Vida : MonoBehaviour {
    [SerializeField] public int vida = 4;

    void Update() {
        if (vida <= 0)
            Destroy(gameObject);
    }
}
