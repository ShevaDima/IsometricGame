using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
  public class Shop : MonoBehaviour
  {
    public PlayerData PlayerData;
    public PlayerMovement PlayerMovement;
    public HeroHealth PlayerHealth;
    public JewelSpawn JewelSpawn;

    public Button CloseButton;

    public Button UpgradeGunButton;
    public Button UpgradeHealthButton;
    public Button UpgradeSpeedButton;
    
    public Text GunPowerText;
    public Text HealthText;
    public Text SpeedText;

    public Text GunPowerCostText;
    public Text HealthCostText;
    public Text SpeedCostText;

    public int GunPowerCost;
    public int HealthCost;
    public int SpeedCost;

    private void Awake()
    {
      GunPowerCostText.text = GunPowerCost.ToString();
      HealthCostText.text = HealthCost.ToString();
      SpeedCostText.text = SpeedCost.ToString();
      
      UpgradeGunButton.onClick.AddListener(() =>
      {
        if (PlayerData.Coins >= GunPowerCost)
        {
          UpgradeWeapon();
          UpdateView();
        }
      });
      
      UpgradeHealthButton.onClick.AddListener(() =>
      {
        if (PlayerData.Coins >= HealthCost)
        {
          Heal();
          UpdateView();
        }
      });
      
      UpgradeSpeedButton.onClick.AddListener(() =>
      {
        if (PlayerData.Coins >= SpeedCost)
        {
          UpgradeSpeed();
          UpdatePlayerOnScene();
          UpdateView();
        }
      });
      
      CloseButton.onClick.AddListener(Close);

      UpdateView();
    }

    public void Open()
    {
      Time.timeScale = 0f;
      gameObject.SetActive(true);
    }

    private void UpgradeWeapon()
    {
      JewelSpawn.SubtractCoins(GunPowerCost);
      PlayerData.WeaponPower += 1;
    }

    private void Heal()
    {
      JewelSpawn.SubtractCoins(HealthCost);
      PlayerHealth.AddHealth(1);
    }

    private void UpgradeSpeed()
    {
      JewelSpawn.SubtractCoins(SpeedCost);
      PlayerData.Speed += 1;
    }

    private void UpdateView()
    {
      GunPowerText.text = PlayerData.WeaponPower.ToString();
      HealthText.text = PlayerHealth.Current.ToString();
      SpeedText.text = PlayerData.Speed.ToString();
    }

    private void UpdatePlayerOnScene()
    {
      PlayerMovement.moveSpeed = PlayerData.Speed;
    }

    private void Close()
    {
      Time.timeScale = 1f;
      gameObject.SetActive(false);
    }
  }
}