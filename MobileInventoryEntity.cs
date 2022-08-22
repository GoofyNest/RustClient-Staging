public class MobileInventoryEntity : BaseEntity // TypeDefIndex: 9450
{	// Fields
	public SoundDefinition ringingLoop; // 0x168
	public SoundDefinition silentLoop; // 0x170
	public const BaseEntity.Flags Ringing = 128;
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private Sound ringingSound; // 0x178

	// Methods

	// RVA: 0x76C9C0 Offset: 0x76AFC0 VA: 0x18076C9C0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76C940 Offset: 0x76AF40 VA: 0x18076C940
	private SoundDefinition GetRingSound() { }

	// RVA: 0x76CD70 Offset: 0x76B370 VA: 0x18076CD70
	public void .ctor() { }

	// RVA: 0x76CD30 Offset: 0x76B330 VA: 0x18076CD30
	private static void .cctor() { }

}

