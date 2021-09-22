using UnityEngine;
using UnityEngine.UI;
using Klak.Ndi;

namespace Nsm {

public sealed class Monitor : MonoBehaviour
{
    [SerializeField] NdiReceiver _receiver = null;

    RawImage _target;
    AspectRatioFitter _fitter;
    Texture2D _empty;

    void Start()
    {
        _target = GetComponent<RawImage>();
        _fitter = GetComponent<AspectRatioFitter>();

        _empty = new Texture2D(1, 1);
        _empty.SetPixel(0, 0, Color.clear);
        _empty.Apply();
    }

    void OnDestroy()
      => Destroy(_empty);

    void Update()
    {
        var tex = _receiver.texture;
        if (tex != null)
        {
            _target.texture = tex;
            _fitter.aspectRatio = (float)tex.width / tex.height;
        }
        else
        {
            _target.texture = _empty;
        }
    }
}

} // namespace Nsm
