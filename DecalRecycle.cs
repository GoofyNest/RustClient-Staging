public class DecalRecycle : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9175
{	// Fields
	public float LifeTime; // 0x20
	private Action recycleAction; // 0x28

	// Methods

	// RVA: 0x840030 Offset: 0x83E630 VA: 0x180840030
	protected void Awake() { }

	// RVA: 0x8400B0 Offset: 0x83E6B0 VA: 0x1808400B0 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0x840310 Offset: 0x83E910 VA: 0x180840310 Slot: 8
	public void Recycle() { }

	// RVA: 0x8402E0 Offset: 0x83E8E0 VA: 0x1808402E0 Slot: 9
	public void OnParentDestroying() { }

	// RVA: 0x83F940 Offset: 0x83DF40 VA: 0x18083F940
	public void .ctor() { }

}

