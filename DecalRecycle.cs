public class DecalRecycle : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9175
{	// Fields
	public float LifeTime; // 0x20
	private Action recycleAction; // 0x28

	// Methods

	// RVA: 0x83F9D0 Offset: 0x83DFD0 VA: 0x18083F9D0
	protected void Awake() { }

	// RVA: 0x83FA50 Offset: 0x83E050 VA: 0x18083FA50 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0x83FCB0 Offset: 0x83E2B0 VA: 0x18083FCB0 Slot: 8
	public void Recycle() { }

	// RVA: 0x83FC80 Offset: 0x83E280 VA: 0x18083FC80 Slot: 9
	public void OnParentDestroying() { }

	// RVA: 0x83F2E0 Offset: 0x83D8E0 VA: 0x18083F2E0
	public void .ctor() { }

}

