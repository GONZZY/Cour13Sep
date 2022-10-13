using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChange : MonoBehaviour
{
    // Philosophie: On ne veut pas attaché élément graphique à a logique, polyvalent
    // et utilisable par n'importe quoi, pas seulement par exemple un bouton mais tout objet.

    
    // Appliquer une couleur sur tous les matériaux meshrenderers
    [SerializeField] private MeshRenderer[] _meshRenderers;
    [SerializeField] public Color color;
    

    public void ChangeColor()
    {
        for (int i = 0; i < _meshRenderers.Length; i++)
        {
            _meshRenderers[i].material.color = color;
        }
    }
}
