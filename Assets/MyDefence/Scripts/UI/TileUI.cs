using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace MyDefence
{
    public class TileUI : MonoBehaviour
    {

        #region Field
        public GameObject offset;

        private Tile selectTile;

        public TextMeshProUGUI upgradeCost;
        public Button upgradeButton;

        public TextMeshProUGUI sellCost;
        public Button sellButton;

        #endregion

        public void ShowTileUI(Tile tile)
        {
            selectTile = tile;
            this.transform.position = tile.transform.position;

            if (selectTile.IsUpgrade)
            {
                upgradeCost.text = "COMPLETE";
                //upgradeButton.interactable = false;
            }
            else
            {
                upgradeCost.text = tile.bluePrint.upgradecost.ToString() + "G";
                //upgradeButton.interactable = true;
            }

            sellCost.text = tile.bluePrint.Sellcost.ToString() + "G";

            offset.SetActive(true);
        }

        public void HideTileUI()
        {
            offset.SetActive(false);
        }

        public void UpgradeTower()
        {
            selectTile.UpgradeTower();

            BuildManager.Instance.DeselectTile();
        }

        public void SellTower()
        {
            selectTile.SellTower();

            BuildManager.Instance.DeselectTile();
        }
    }
}
