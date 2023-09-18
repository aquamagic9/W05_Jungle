using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlackCube : MonoBehaviour
{
    private Material _mat;
    private BoxCollider _boxCollider;
    void Start()
    {
        _mat = gameObject.GetComponent<MeshRenderer>().material;
        _boxCollider = gameObject.GetComponent<BoxCollider>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            FadeOut();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            FadeOut();
        }
    }

    void FadeOut()
    {
        _mat.DOColor(Color.red, 2f).OnComplete(() =>
        {
            this.gameObject.SetActive(false);
        });
    }
}
