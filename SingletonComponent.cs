public abstract class SingletonComponent : FacepunchBehaviour // TypeDefIndex: 5594
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SingletonSetup();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SingletonClear();

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x95FE40 Offset: 0x95E440 VA: 0x18095FE40 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x21BD870 Offset: 0x21BBE70 VA: 0x1821BD870
	public static void InitializeSingletons(GameObject go) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	protected void .ctor() { }

}

