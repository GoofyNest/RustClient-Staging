public class TweakUIBase : MonoBehaviour // TypeDefIndex: 11143
{	// Fields
	public string convarName; // 0x18
	public bool ApplyImmediatelyOnChange; // 0x20
	internal ConsoleSystem.Command conVar; // 0x28

	// Methods

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40
	private void Awake() { }

	// RVA: 0x4D3F60 Offset: 0x4D2560 VA: 0x1804D3F60 Slot: 4
	protected virtual void Init() { }

	// RVA: 0x4D4080 Offset: 0x4D2680 VA: 0x1804D4080 Slot: 5
	public virtual void OnApplyClicked() { }

	// RVA: 0x4D4120 Offset: 0x4D2720 VA: 0x1804D4120 Slot: 6
	public virtual void UnapplyChanges() { }

	// RVA: 0x4C27F0 Offset: 0x4C0DF0 VA: 0x1804C27F0 Slot: 7
	protected virtual void OnConVarChanged(ConsoleSystem.Command obj) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void ResetToConvar() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void SetConvarValue() { }

	// RVA: 0x4D40A0 Offset: 0x4D26A0 VA: 0x1804D40A0
	private void OnDestroy() { }

	// RVA: 0x4D4140 Offset: 0x4D2740 VA: 0x1804D4140
	public void .ctor() { }

}

