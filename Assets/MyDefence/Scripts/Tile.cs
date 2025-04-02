using Unity.VisualScripting;
using UnityEngine;

namespace MyDefence { 
public class Tile : MonoBehaviour
{
        #region Field
        //public Color hoverColor;

       // private Color startColor;

        public Material hoverMaterial;
        private Material startMaterial;

        private Renderer renderer;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            renderer = this.transform.GetComponent<Renderer>();
            //startColor = renderer.material.color;
            startMaterial = renderer.material;
        }
        private void OnMouseDown()
        {
            //Debug.Log("터렛 설치");
            //Instantiate(towerPrefab, this.transform.position, Quaternion.identity);
            Instantiate(BuildManager.Instance.GetTowerToBuild(), this.transform.position, Quaternion.identity);
        }
        private void OnMouseEnter()
        {
            
            //renderer.material.color=hoverColor;
            renderer.material=hoverMaterial;
        }
        //private void OnMouseDrag()
        //{
        //    Debug.Log("OnMouseDrag");
        //}

        private void OnMouseExit()
        {
            Debug.Log("OnMousExist");
            //renderer.material.color = hoverColor;
            //renderer.material.color = Color.white;
            renderer.material = startMaterial;
        }
    }
}
