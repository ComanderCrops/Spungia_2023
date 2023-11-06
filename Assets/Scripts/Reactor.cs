using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Reactor : IInteractible
{
    [SerializeField] Item_SO uranium;

    InventoryManager inventory;
    UImanager uiManager;

    void Start()
    {
        inventory = Camera.main.GetComponent<InventoryManager>();
        uiManager = Camera.main.GetComponent<UImanager>();
    }

    public override void OnPointerClick(PointerEventData pointerEventData)
    {
        if (!inventory.ContainsItem(uranium))
        {
            return;
        }

        SceneManager.LoadScene(2);
    }

    public override void OnPointerEnter(PointerEventData pointerEventData)
    {
        uiManager.UpdateTooltip("Tinker with reactor - use Uranium", transform.position);
        base.OnPointerEnter(pointerEventData);
    }

    public override void OnPointerExit(PointerEventData pointerEventData)
    {
        uiManager.HideTooltip();
        base.OnPointerExit(pointerEventData);
    }
}
