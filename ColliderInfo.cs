public class ColliderInfo : MonoBehaviour // TypeDefIndex: 9837
{	// Fields
	public const ColliderInfo.Flags FlagsNone = 0;
	public const ColliderInfo.Flags FlagsEverything = -1;
	public const ColliderInfo.Flags FlagsDefault = 15;
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ColliderInfo.Flags flags; // 0x18

	// Methods

	// RVA: 0x57C840 Offset: 0x57AE40 VA: 0x18057C840
	public bool HasFlag(ColliderInfo.Flags f) { }

	// RVA: 0x57C850 Offset: 0x57AE50 VA: 0x18057C850
	public void SetFlag(ColliderInfo.Flags f, bool b) { }

	// RVA: 0x57C7F0 Offset: 0x57ADF0 VA: 0x18057C7F0
	public bool Filter(HitTest info) { }

	// RVA: 0x57C870 Offset: 0x57AE70 VA: 0x18057C870
	public void .ctor() { }

}

public enum ColliderInfo.Flags // TypeDefIndex: 9838
{	// Fields
	public int value__; // 0x0
	public const ColliderInfo.Flags Usable = 1;
	public const ColliderInfo.Flags Shootable = 2;
	public const ColliderInfo.Flags Melee = 4;
	public const ColliderInfo.Flags Opaque = 8;
	public const ColliderInfo.Flags Airflow = 16;

}

