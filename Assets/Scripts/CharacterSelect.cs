﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] private BearBox[] _bearBoxes;
    [SerializeField] private Light _spotLight;

    [SerializeField] private int _selectedIndex;

    private bool _newTarget = false;

    [SerializeField, Range(0, 10)] private float _rotateSpeed;

    private void Start()
    {
        _spotLight.intensity = 0;
    }

    public void Selected(BearBox selected)
    {
        if (_spotLight.intensity == 0)
        {
            _spotLight.intensity = 9;
        }
        for (int i = 0; i < _bearBoxes.Length; i++)
        {
            if (_bearBoxes[i] == selected)
            {
                _bearBoxes[i].Select();
                _selectedIndex = i;
                _spotLight.transform.LookAt(_bearBoxes[i].transform.position + .5f * Vector3.up);
                CharacterPrefs.PlayerBear = i;
            }
            else
            {
                _bearBoxes[i].Deselect();
            }
        }
    }
}