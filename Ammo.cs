public enum AmmoTypes // TypeDefIndex: 6619
{	// Fields
	public int value__; // 0x0
	public const AmmoTypes PISTOL_9MM = 1;
	public const AmmoTypes RIFLE_556MM = 2;
	public const AmmoTypes SHOTGUN_12GUAGE = 4;
	public const AmmoTypes BOW_ARROW = 8;
	public const AmmoTypes HANDMADE_SHELL = 16;
	public const AmmoTypes ROCKET = 32;
	public const AmmoTypes NAILS = 64;
	public const AmmoTypes AMMO_40MM = 128;
	public const AmmoTypes SNOWBALL = 256;
	public const AmmoTypes SPEARGUN_BOLT = 512;
	public const AmmoTypes TORPEDO = 1024;
	public const AmmoTypes MLRS_ROCKET = 2048;

}

public class AmmoBelowAIEvent : BaseAIEvent // TypeDefIndex: 9389
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Value>k__BackingField; // 0x40

	// Properties
	public float Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	private void set_Value(float value) { }

	// RVA: 0x823000 Offset: 0x821600 VA: 0x180823000
	public void .ctor() { }

}

public class AmmoBelowEventUI : BaseEventUI // TypeDefIndex: 10785
{	// Methods

	// RVA: 0x8230A0 Offset: 0x8216A0 VA: 0x1808230A0 Slot: 5
	public override AIEventData Save() { }

	// RVA: 0x823030 Offset: 0x821630 VA: 0x180823030 Slot: 6
	public override void Load(AIEventData data) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class AmmoInformationPanel : ItemInformationPanel // TypeDefIndex: 10980
{	// Fields
	public ItemStatValue damageDisplay; // 0x18
	public ItemStatValue velocityDisplay; // 0x20
	public ItemStatValue spreadDisplay; // 0x28
	public ItemTextValue pelletsDisplay; // 0x30
	public ItemStatValue falloffRangeDisplay; // 0x38
	public ItemTextValue thicknessDisplay; // 0x40

	// Methods

	// RVA: 0x823150 Offset: 0x821750 VA: 0x180823150 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8232E0 Offset: 0x8218E0 VA: 0x1808232E0 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

