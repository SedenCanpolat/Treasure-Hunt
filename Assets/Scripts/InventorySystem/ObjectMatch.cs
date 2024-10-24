using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMatch : MonoBehaviour
{

    public List<Item> keys;
    public List<GameObject> values;

    // Dictionary to hold the key-value pairs at runtime
    private Dictionary<Item, GameObject> ObjectTargetDictionary;

    private void Awake()
    {
        // Initialize the dictionary and populate it using the keys and values lists
        ObjectTargetDictionary = new Dictionary<Item, GameObject>();

        for (int i = 0; i < keys.Count && i < values.Count; i++)
        {
            if (!ObjectTargetDictionary.ContainsKey(keys[i]))
            {
                ObjectTargetDictionary.Add(keys[i], values[i]);
            }
        }
    }

}
