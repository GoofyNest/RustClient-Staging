public class TerrainColors : TerrainExtension // TypeDefIndex: 10388
{	// Fields
	private TerrainSplatMap splatMap; // 0x30
	private TerrainBiomeMap biomeMap; // 0x38

	// Methods

	// RVA: 0x113DB10 Offset: 0x113C110 VA: 0x18113DB10 Slot: 4
	public override void Setup() { }

	// RVA: 0x113D550 Offset: 0x113BB50 VA: 0x18113D550
	public Color GetColor(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x113D6D0 Offset: 0x113BCD0 VA: 0x18113D6D0
	public Color GetColor(float normX, float normZ, int mask = -1) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

