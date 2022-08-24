public class CinematicEntity : BaseEntity // TypeDefIndex: 9275
{	private const BaseEntity.Flags HideMesh = 128;
	public GameObject[] DisableObjects; // 0x168
	private static List<CinematicEntity> clientList; // 0x0
	public static Nullable<bool> demoOverride; // 0x8


	public override void ClientOnEnable() { }

	[ClientVar] // RVA: 0xE6A40 Offset: 0xE5E40 VA: 0x1800E6A40
	public static void DemoHideObjects(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static void RemoveDemoOverride() { }

	public override void DestroyShared() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void ToggleObjects(bool state) { }

	public void .ctor() { }

	private static void .cctor() { }

}

