public class SwapArrows : MonoBehaviour, IClientComponent // TypeDefIndex: 11445
{	// Fields
	public GameObject[] arrowModels; // 0x18
	private string curAmmoType; // 0x20
	private bool wasHidden; // 0x28

	// Methods

	// RVA: 0x7A6900 Offset: 0x7A4F00 VA: 0x1807A6900
	public void SelectArrowType(int iType) { }

	// RVA: 0x7A6820 Offset: 0x7A4E20 VA: 0x1807A6820
	public void HideAllArrowHeads() { }

	// RVA: 0x7A69C0 Offset: 0x7A4FC0 VA: 0x1807A69C0
	public void UpdateAmmoType(ItemDefinition ammoType, bool hidden = False) { }

	// RVA: 0x7A6780 Offset: 0x7A4D80 VA: 0x1807A6780
	private void Cleanup() { }

	// RVA: 0x7A6880 Offset: 0x7A4E80 VA: 0x1807A6880
	public void OnDisable() { }

	// RVA: 0x7A68F0 Offset: 0x7A4EF0 VA: 0x1807A68F0
	public void OnEnable() { }

	// RVA: 0x7A6B70 Offset: 0x7A5170 VA: 0x1807A6B70
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

