public class SwapRPG : MonoBehaviour // TypeDefIndex: 11448
{	// Fields
	public GameObject[] rpgModels; // 0x18
	private string curAmmoType; // 0x20

	// Methods

	// RVA: 0x7A6C00 Offset: 0x7A5200 VA: 0x1807A6C00
	public void SelectRPGType(int iType) { }

	// RVA: 0x7A6CB0 Offset: 0x7A52B0 VA: 0x1807A6CB0
	public void UpdateAmmoType(ItemDefinition ammoType) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x7A6DB0 Offset: 0x7A53B0 VA: 0x1807A6DB0
	public void .ctor() { }

}

public enum SwapRPG.RPGType // TypeDefIndex: 11449
{	// Fields
	public int value__; // 0x0
	public const SwapRPG.RPGType One = 0;
	public const SwapRPG.RPGType Two = 1;
	public const SwapRPG.RPGType Three = 2;
	public const SwapRPG.RPGType Four = 3;

}
