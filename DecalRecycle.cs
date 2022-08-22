public class DecalRecycle : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9175
{	// Fields
	public float LifeTime; // 0x20
	private Action recycleAction; // 0x28

	// Methods

	// RVA: 0x83FAE0 Offset: 0x83E0E0 VA: 0x18083FAE0
	protected void Awake() { }

	// RVA: 0x83FB60 Offset: 0x83E160 VA: 0x18083FB60 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0x83FDC0 Offset: 0x83E3C0 VA: 0x18083FDC0 Slot: 8
	public void Recycle() { }

	// RVA: 0x83FD90 Offset: 0x83E390 VA: 0x18083FD90 Slot: 9
	public void OnParentDestroying() { }

	// RVA: 0x83F3F0 Offset: 0x83D9F0 VA: 0x18083F3F0
	public void .ctor() { }

}

