public class TweakUIBase : MonoBehaviour // TypeDefIndex: 11143
{	// Fields
	public string convarName; // 0x18
	public bool ApplyImmediatelyOnChange; // 0x20
	internal ConsoleSystem.Command conVar; // 0x28

	// Methods

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	private void Awake() { }

	// RVA: 0x4D3FD0 Offset: 0x4D25D0 VA: 0x1804D3FD0 Slot: 4
	protected virtual void Init() { }

	// RVA: 0x4D40F0 Offset: 0x4D26F0 VA: 0x1804D40F0 Slot: 5
	public virtual void OnApplyClicked() { }

	// RVA: 0x4D4190 Offset: 0x4D2790 VA: 0x1804D4190 Slot: 6
	public virtual void UnapplyChanges() { }

	// RVA: 0x4C2860 Offset: 0x4C0E60 VA: 0x1804C2860 Slot: 7
	protected virtual void OnConVarChanged(ConsoleSystem.Command obj) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void ResetToConvar() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void SetConvarValue() { }

	// RVA: 0x4D4110 Offset: 0x4D2710 VA: 0x1804D4110
	private void OnDestroy() { }

	// RVA: 0x4D41B0 Offset: 0x4D27B0 VA: 0x1804D41B0
	public void .ctor() { }

}

