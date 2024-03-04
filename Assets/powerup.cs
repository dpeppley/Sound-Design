using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        AudioSource audio = GetComponent<AudioSource>();
        audio.pitch = 2.0f - gameObject.transform.localScale.x; 
        audio.Play();
        GetComponent<MeshRenderer>().enabled = false;
        if(!GetComponent<AudioSource>().isPlaying) {
            Destroy(this.gameObject);
        }
    }
}
