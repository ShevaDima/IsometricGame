using System;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
  public Image ImageCurrent;

  public HeroHealth Health;

  private void Start()
  {
    Health.Changed += UpdateHpBar;
  }

  private void OnDestroy()
  {
    Health.Changed -= UpdateHpBar;
  }

  private void UpdateHpBar()
  {
    SetValue(Health.Current, Health.Max);
  }

  private void SetValue(float current, float max)
  {
    ImageCurrent.fillAmount = current / max;
  }
}