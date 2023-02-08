using UnityEngine;

public class Stats : MonoBehaviour {
    [SerializeField] public int vida = 4;

    [SerializeField] public int especial = 2;

    void Update() {
        if (vida <= 0)
            Destroy(gameObject);
    }
    
}
