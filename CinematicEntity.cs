public class CinematicEntity : BaseEntity // TypeDefIndex: 9275
{	// Fields
	private const BaseEntity.Flags HideMesh = 128;
	public GameObject[] DisableObjects; // 0x168
	private static List<CinematicEntity> clientList; // 0x0
	public static Nullable<bool> demoOverride; // 0x8

	// Methods

	// RVA: 0x53B510 Offset: 0x539B10 VA: 0x18053B510 Slot: 13
	public override void ClientOnEnable() { }

	[ClientVar] // RVA: 0xE69B0 Offset: 0xE5DB0 VA: 0x1800E69B0
	// RVA: 0x53B650 Offset: 0x539C50 VA: 0x18053B650
	public static void DemoHideObjects(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	// RVA: 0x53BAE0 Offset: 0x53A0E0 VA: 0x18053BAE0
	public static void RemoveDemoOverride() { }

	// RVA: 0x53B840 Offset: 0x539E40 VA: 0x18053B840 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x53B990 Offset: 0x539F90 VA: 0x18053B990 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x53BCB0 Offset: 0x53A2B0 VA: 0x18053BCB0
	private void ToggleObjects(bool state) { }

	// RVA: 0x53BE10 Offset: 0x53A410 VA: 0x18053BE10
	public void .ctor() { }

	// RVA: 0x53BD90 Offset: 0x53A390 VA: 0x18053BD90
	private static void .cctor() { }

}

