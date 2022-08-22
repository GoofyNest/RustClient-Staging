public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 4990
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Navigation.Mode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public Navigation.Mode get_mode() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public Selectable get_selectOnUp() { }

	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public Selectable get_selectOnDown() { }

	// RVA: 0xF1470 Offset: 0xF0870 VA: 0x1800F1470
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public Selectable get_selectOnLeft() { }

	// RVA: 0xF1480 Offset: 0xF0880 VA: 0x1800F1480
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0xF3730 Offset: 0xF2B30 VA: 0x1800F3730
	public Selectable get_selectOnRight() { }

	// RVA: 0xF14E0 Offset: 0xF08E0 VA: 0x1800F14E0
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x17105F0 Offset: 0x170EBF0 VA: 0x1817105F0
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x207490 Offset: 0x206890 VA: 0x180207490 Slot: 4
	public bool Equals(Navigation other) { }

}

public enum Navigation.Mode // TypeDefIndex: 4991
{	// Fields
	public int value__; // 0x0
	public const Navigation.Mode None = 0;
	public const Navigation.Mode Horizontal = 1;
	public const Navigation.Mode Vertical = 2;
	public const Navigation.Mode Automatic = 3;
	public const Navigation.Mode Explicit = 4;

}

