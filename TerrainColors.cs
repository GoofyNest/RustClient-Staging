public class TerrainColors : TerrainExtension // TypeDefIndex: 10388
{	// Fields
	private TerrainSplatMap splatMap; // 0x30
	private TerrainBiomeMap biomeMap; // 0x38

	// Methods

	// RVA: 0x113D850 Offset: 0x113BE50 VA: 0x18113D850 Slot: 4
	public override void Setup() { }

	// RVA: 0x113D290 Offset: 0x113B890 VA: 0x18113D290
	public Color GetColor(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x113D410 Offset: 0x113BA10 VA: 0x18113D410
	public Color GetColor(float normX, float normZ, int mask = -1) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

