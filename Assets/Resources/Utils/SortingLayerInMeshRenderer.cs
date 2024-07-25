using UnityEngine;

public class SortingLayerInMeshRenderer : MonoBehaviour
{
    public string layerName;
    public int order;
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.sortingLayerName = layerName;
        meshRenderer.sortingOrder = order;
    }
}
