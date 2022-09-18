using System;
using System.Collections.Generic;
using UnityEngine;

namespace ForestOfMysteries.Papers
{
    public class Paper : Story
    {
        [Range(0, 9)]
        [SerializeField] private int _number;
        [SerializeField] private AudioSource _sound;


        private Dictionary<int, string> _collectionNotes = new Dictionary<int, string>();

        
        private void Start()
        {
            for (int i = 0; i < _story.Count; i++)
            {
                _collectionNotes.Add(i, _story[i]);
            }
        }

    }
}