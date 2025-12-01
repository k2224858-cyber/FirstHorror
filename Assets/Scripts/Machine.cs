using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject pressE;
    [SerializeField] GameManager _gameManager;
    [SerializeField] SpriteRenderer _machineON;
    SpriteRenderer _machineOFF;
    private float _repairTime = 3.0f;
    private float _spentTime;
    private bool _isON;

    private void Start()
    {
        _machineOFF = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Vector2.Distance(player.transform.position, pressE.transform.position) < 1.5f)
        {
            pressE.SetActive(true);
        }
        else
        {
            pressE.SetActive(false);
        }

        if (Input.GetKey(KeyCode.E) && Vector2.Distance(player.transform.position, pressE.transform.position) < 1.5f && !_isON)
        {
            _spentTime += Time.deltaTime;
        }

        if (_spentTime / _repairTime >= 1 && !_isON)
        {
            ChangeMachinesState();
            _gameManager.PlusOne();
        }
    }

    public void ChangeMachinesState()
    {
        _isON = true;
        _machineOFF.enabled = false;
        _machineON.enabled = true;
    }
}
