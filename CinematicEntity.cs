public class CinematicEntity : BaseEntity // TypeDefIndex: 9275
{	// Fields
	private const BaseEntity.Flags HideMesh = 128;
	public GameObject[] DisableObjects; // 0x168
	private static List<CinematicEntity> clientList; // 0x0
	public static Nullable<bool> demoOverride; // 0x8

	// Methods

	// RVA: 0x53B4A0 Offset: 0x539AA0 VA: 0x18053B4A0 Slot: 13
	public override void ClientOnEnable() { }

	[ClientVar] // RVA: 0xE6A50 Offset: 0xE5E50 VA: 0x1800E6A50
	// RVA: 0x53B5E0 Offset: 0x539BE0 VA: 0x18053B5E0
	public static void DemoHideObjects(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x53BA70 Offset: 0x53A070 VA: 0x18053BA70
	public static void RemoveDemoOverride() { }

	// RVA: 0x53B7D0 Offset: 0x539DD0 VA: 0x18053B7D0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x53B920 Offset: 0x539F20 VA: 0x18053B920 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x53BC40 Offset: 0x53A240 VA: 0x18053BC40
	private void ToggleObjects(bool state) { }

	// RVA: 0x53BDA0 Offset: 0x53A3A0 VA: 0x18053BDA0
	public void .ctor() { }

	// RVA: 0x53BD20 Offset: 0x53A320 VA: 0x18053BD20
	private static void .cctor() { }

}

