public class ColliderInfo : MonoBehaviour // TypeDefIndex: 9837
{	// Fields
	public const ColliderInfo.Flags FlagsNone = 0;
	public const ColliderInfo.Flags FlagsEverything = -1;
	public const ColliderInfo.Flags FlagsDefault = 15;
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public ColliderInfo.Flags flags; // 0x18

	// Methods

	// RVA: 0x57C8B0 Offset: 0x57AEB0 VA: 0x18057C8B0
	public bool HasFlag(ColliderInfo.Flags f) { }

	// RVA: 0x57C8C0 Offset: 0x57AEC0 VA: 0x18057C8C0
	public void SetFlag(ColliderInfo.Flags f, bool b) { }

	// RVA: 0x57C860 Offset: 0x57AE60 VA: 0x18057C860
	public bool Filter(HitTest info) { }

	// RVA: 0x57C8E0 Offset: 0x57AEE0 VA: 0x18057C8E0
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

