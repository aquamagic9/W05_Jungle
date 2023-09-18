using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlueCube : MonoBehaviour
{
    private MeshRenderer _mat;
    private Vector3 _topPosition;
    private Vector3 _bottomPosition;
    public Transform TopPlatformTransform;
    public Transform BottomPlatformTransform;
    public bool LocatedTop = false;
    public float Distance = 7f;

    private void Start()
    {
        _mat = GetComponent<MeshRenderer>();
        Distance = TopPlatformTransform.position.y - BottomPlatformTransform.position.y;
        if (LocatedTop)
        {
            _topPosition = this.transform.position;
            _bottomPosition = this.transform.position + new Vector3(0.0f, -Distance, 0.0f);
        }
        else
        {
            _topPosition = this.transform.position + new Vector3(0.0f, Distance, 0.0f);
            _bottomPosition = this.transform.position;
        }
    }
    
    public void CubeMove()
    {
        if (!DOTween.IsTweening(this))
        {
            if (LocatedTop)
            {
                transform.DOMove(_bottomPosition, 1f);
                LocatedTop = false;
            }
            else
            {
                transform.DOMove(_topPosition, 1f);
                LocatedTop = true;
            }
        }
    }
}
