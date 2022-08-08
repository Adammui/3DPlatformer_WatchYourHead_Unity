using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationArrows : MonoBehaviour
{
    [SerializeField]
    private int _numberOfLanguages;
    [SerializeField]
    private LocalizationManager _localizationManager;

    public void localizeText(int increment)
    {
        int newLocalizationId = (LocalizationManager.SelectedLanguage + increment + _numberOfLanguages) % _numberOfLanguages;
        _localizationManager.SetLanguage(newLocalizationId);
    }
}
