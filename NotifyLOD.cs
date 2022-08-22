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

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x9D48A0 Offset: 0x9D2EA0 VA: 0x1809D48A0 Slot: 13
	protected override void Show() { }

	// RVA: 0x9D47D0 Offset: 0x9D2DD0 VA: 0x1809D47D0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A80 Offset: 0x4C6080 VA: 0x1804C7A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x9D4700 Offset: 0x9D2D00 VA: 0x1809D4700 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x9D4970 Offset: 0x9D2F70 VA: 0x1809D4970
	public void .ctor() { }

}

