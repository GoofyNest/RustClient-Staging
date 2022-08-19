public class SwapArrows : MonoBehaviour, IClientComponent // TypeDefIndex: 11445
{	// Fields
	public GameObject[] arrowModels; // 0x18
	private string curAmmoType; // 0x20
	private bool wasHidden; // 0x28

	// Methods

	// RVA: 0x7A67F0 Offset: 0x7A4DF0 VA: 0x1807A67F0
	public void SelectArrowType(int iType) { }

	// RVA: 0x7A6710 Offset: 0x7A4D10 VA: 0x1807A6710
	public void HideAllArrowHeads() { }

	// RVA: 0x7A68B0 Offset: 0x7A4EB0 VA: 0x1807A68B0
	public void UpdateAmmoType(ItemDefinition ammoType, bool hidden = False) { }

	// RVA: 0x7A6670 Offset: 0x7A4C70 VA: 0x1807A6670
	private void Cleanup() { }

	// RVA: 0x7A6770 Offset: 0x7A4D70 VA: 0x1807A6770
	public void OnDisable() { }

	// RVA: 0x7A67E0 Offset: 0x7A4DE0 VA: 0x1807A67E0
	public void OnEnable() { }

	// RVA: 0x7A6A60 Offset: 0x7A5060 VA: 0x1807A6A60
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

