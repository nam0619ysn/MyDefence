using UnityEngine;
using TMPro;
using System.Collections;
namespace MyDefence
{
    public class RoundsText : MonoBehaviour
    {
        #region Field
        public TextMeshProUGUI roundText;

        #endregion
        private void OnEnable()
        {
            StartCoroutine(AnimateNumberText(PlayerStats.Rounds));
        }

        IEnumerator AnimateNumberText(int targetNumber)
        {
            int aniNumber = 0;
            roundText.text = aniNumber.ToString();
            yield return new WaitForSeconds(0.1f);

            while(aniNumber<targetNumber)
            {
                aniNumber++;
                roundText.text = aniNumber.ToString();
                yield return new WaitForSeconds(0.05f);

            }
            //애니메이션 종료

        }
    }
}