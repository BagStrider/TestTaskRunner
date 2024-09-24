using System.Collections.Generic;
using UnityEngine;

public class PlayerModelSwitcher : MonoBehaviour
{
    [SerializeField] private List<GameObject> _models = new List<GameObject>();

    [SerializeField] private  PlayerView _playerView;

    public void SwitchModelByIndex(int index)
    {
        foreach(GameObject model in _models)
        {
            model.SetActive(false);
        }

        _models[index].SetActive(true);

        _playerView.PlaySwitchAnimation();
    }
}
