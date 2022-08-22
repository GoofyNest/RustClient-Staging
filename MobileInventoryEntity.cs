public class MobileInventoryEntity : BaseEntity // TypeDefIndex: 9450
{	// Fields
	public SoundDefinition ringingLoop; // 0x168
	public SoundDefinition silentLoop; // 0x170
	public const BaseEntity.Flags Ringing = 128;
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private Sound ringingSound; // 0x178

	// Methods

	// RVA: 0x76CA70 Offset: 0x76B070 VA: 0x18076CA70 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76C9F0 Offset: 0x76AFF0 VA: 0x18076C9F0
	private SoundDefinition GetRingSound() { }

	// RVA: 0x76CE20 Offset: 0x76B420 VA: 0x18076CE20
	public void .ctor() { }

	// RVA: 0x76CDE0 Offset: 0x76B3E0 VA: 0x18076CDE0
	private static void .cctor() { }

}

