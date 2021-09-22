using UnityEngine;
using UnityEngine.UI;
using Klak.Ndi;

namespace Nsm {

public sealed class Monitor : MonoBehaviour
{
    [SerializeField] NdiReceiver _receiver = null;

    RawImage _target;
    Texture2D _empty;

    void Start()
    {
        _target = GetComponent<RawImage>();

        _empty = new Texture2D(1, 1);
        _empty.SetPixel(0, 0, Color.clear);
        _empty.Apply();
    }

    void OnDestroy()
      => Destroy(_empty);

    void Update()
      => _target.texture =
        _receiver.texture != null ? _receiver.texture : _empty;
}

} // namespace Nsm
