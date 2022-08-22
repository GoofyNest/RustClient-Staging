public class SwapArrows : MonoBehaviour, IClientComponent // TypeDefIndex: 11445
{	// Fields
	public GameObject[] arrowModels; // 0x18
	private string curAmmoType; // 0x20
	private bool wasHidden; // 0x28

	// Methods

	// RVA: 0x7C4D00 Offset: 0x7C3300 VA: 0x1807C4D00
	public void SelectArrowType(int iType) { }

	// RVA: 0x7C4C20 Offset: 0x7C3220 VA: 0x1807C4C20
	public void HideAllArrowHeads() { }

	// RVA: 0x7C4DC0 Offset: 0x7C33C0 VA: 0x1807C4DC0
	public void UpdateAmmoType(ItemDefinition ammoType, bool hidden = False) { }

	// RVA: 0x7C4B80 Offset: 0x7C3180 VA: 0x1807C4B80
	private void Cleanup() { }

	// RVA: 0x7C4C80 Offset: 0x7C3280 VA: 0x1807C4C80
	public void OnDisable() { }

	// RVA: 0x7C4CF0 Offset: 0x7C32F0 VA: 0x1807C4CF0
	public void OnEnable() { }

	// RVA: 0x7C4F70 Offset: 0x7C3570 VA: 0x1807C4F70
	public void .ctor() { }

}

public enum SwapArrows.ArrowType // TypeDefIndex: 11446
{	// Fields
	public int value__; // 0x0
	public const SwapArrows.ArrowType One = 0;
	public const SwapArrows.ArrowType Two = 1;
	public const SwapArrows.ArrowType Three = 2;
	public const SwapArrows.ArrowType Four = 3;

}

