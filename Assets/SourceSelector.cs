using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;
using System.Linq;
using Klak.Ndi;
using Cursor = UnityEngine.Cursor;

namespace Nsm {

public sealed class SourceSelector : MonoBehaviour
{
    #region Data source accessor for UI

    [CreateProperty]
    public List<string> SourceList
      => NdiFinder.sourceNames.DefaultIfEmpty(NoSource).ToList();

    #endregion

    #region External component references

    NdiReceiver Receiver
      => GetComponent<NdiReceiver>();

    VisualElement UIRoot
      => GetComponent<UIDocument>().rootVisualElement;

    DropdownField UISelector
      => UIRoot.Q<DropdownField>("selector");

    VisualElement UIMonitor
      => UIRoot.Q<VisualElement>("monitor");

    #endregion

    #region Private members

    const string PrefKey = "NDI Source Name";
    const string NoSource = "(No NDI source found)";

    #endregion

    #region UI callbacks

    void ToggleUI()
      => Cursor.visible = (UISelector.visible ^= true);

    void SelectSource(string name)
    {
        if (name == NoSource)
        {
            // Is it actually safe to change the index in the callback?
            // It looks a little bit dangerous.
            UISelector.index = -1;
        }
        else
        {
            Receiver.ndiName = name;
            PlayerPrefs.SetString(PrefKey, name);
        }
    }

    #endregion

    #region MonoBehaviour

    void Start()
    {
        UIRoot.AddManipulator(new Clickable(ToggleUI));

        UISelector.dataSource = this;
        UISelector.RegisterValueChangedCallback(e => SelectSource(e.newValue));

        if (PlayerPrefs.HasKey(PrefKey))
            SelectSource(UISelector.value = PlayerPrefs.GetString(PrefKey));

#if UNITY_IOS && !UNITY_EDITOR
        Application.targetFrameRate = 60;
#endif
    }

    void Update()
      => UIMonitor.style.backgroundImage
           = Background.FromRenderTexture(Receiver.texture);

    #endregion
}

} // namespace Nsm
