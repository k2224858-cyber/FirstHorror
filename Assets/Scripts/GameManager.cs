using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private Machine[] _machines;
    private int _machinesON;
    void Start()
    {
        _score.text = $"{_machinesON} / {_machines.Length}";
    }

    void Update()
    {

    }

    public void PlusOne()
    {
        if (_machines.Length > _machinesON + 1)
        {
            _machinesON++;
            _score.text = $"{_machinesON} / {_machines.Length}";
        }
        else
        {
            _score.text = "YOU WIN!!!";
        }
    }
}
