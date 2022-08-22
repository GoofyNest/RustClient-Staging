public abstract class TerrainExtension : MonoBehaviour // TypeDefIndex: 10389
{	// Fields
	public bool isInitialized; // 0x18
	internal Terrain terrain; // 0x20
	internal TerrainConfig config; // 0x28

	// Methods

	// RVA: 0x7F9C60 Offset: 0x7F8260 VA: 0x1807F9C60
	public void Init(Terrain terrain, TerrainConfig config) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void Setup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void PostSetup() { }

	// RVA: 0x11406F0 Offset: 0x113ECF0 VA: 0x1811406F0
	public void LogSize(object obj, ulong size) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

