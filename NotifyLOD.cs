public class NotifyLOD : LODComponent // TypeDefIndex: 9944
{	// Fields
	public float Distance; // 0x80
	public float MinDistanceMultiplier; // 0x84
	public GameObject TargetGameObject; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private INotifyLOD lodTarget; // 0x98

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C78B0 Offset: 0x4C5EB0 VA: 0x1804C78B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x9D4D90 Offset: 0x9D3390 VA: 0x1809D4D90 Slot: 13
	protected override void Show() { }

	// RVA: 0x9D4CC0 Offset: 0x9D32C0 VA: 0x1809D4CC0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A10 Offset: 0x4C6010 VA: 0x1804C7A10 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x9D4BF0 Offset: 0x9D31F0 VA: 0x1809D4BF0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x9D4E60 Offset: 0x9D3460 VA: 0x1809D4E60
	public void .ctor() { }

}

