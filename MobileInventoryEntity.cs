public class MobileInventoryEntity : BaseEntity // TypeDefIndex: 9450
{	// Fields
	public SoundDefinition ringingLoop; // 0x168
	public SoundDefinition silentLoop; // 0x170
	public const BaseEntity.Flags Ringing = 128;
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private Sound ringingSound; // 0x178

	// Methods

	// RVA: 0x76C960 Offset: 0x76AF60 VA: 0x18076C960 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76C8E0 Offset: 0x76AEE0 VA: 0x18076C8E0
	private SoundDefinition GetRingSound() { }

	// RVA: 0x76CD10 Offset: 0x76B310 VA: 0x18076CD10
	public void .ctor() { }

	// RVA: 0x76CCD0 Offset: 0x76B2D0 VA: 0x18076CCD0
	private static void .cctor() { }

}

