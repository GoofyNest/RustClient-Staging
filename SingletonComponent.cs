public abstract class SingletonComponent : FacepunchBehaviour // TypeDefIndex: 5594
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SingletonSetup();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SingletonClear();

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x21BCF50 Offset: 0x21BB550 VA: 0x1821BCF50
	public static void InitializeSingletons(GameObject go) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	protected void .ctor() { }

}

