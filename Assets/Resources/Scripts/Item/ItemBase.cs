using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace com.dankstudios
{
    public class ItemBase : MonoBehaviour
    {
        [SerializeField] public GameObject _prefab;
        [SerializeField] public Sprite _icon;
        [SerializeField] public string _itemName;
        [SerializeField] public string _itemDescription;
    }
}