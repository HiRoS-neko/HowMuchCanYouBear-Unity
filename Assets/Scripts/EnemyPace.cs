using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.XR.WSA;

[RequireComponent(typeof(Animator))]
public class EnemyPace : MonoBehaviour
{
    [SerializeField] private float _distance;

    private Vector3 _pos;

    private Animator _anim;

    // Use this for initialization
    void Start()
    {
        _anim = GetComponent<Animator>();
        _pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, _pos) > _distance)
        {
            _anim.SetBool("turn", true);
            _pos = transform.position;
        }
        else
        {
            _anim.SetBool("turn", false);
        }
    }
}