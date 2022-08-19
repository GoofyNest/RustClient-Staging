public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 4990
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Navigation.Mode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public Navigation.Mode get_mode() { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public Selectable get_selectOnUp() { }

	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public Selectable get_selectOnDown() { }

	// RVA: 0xF14F0 Offset: 0xF08F0 VA: 0x1800F14F0
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	public Selectable get_selectOnLeft() { }

	// RVA: 0xF1500 Offset: 0xF0900 VA: 0x1800F1500
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0xF37B0 Offset: 0xF2BB0 VA: 0x1800F37B0
	public Selectable get_selectOnRight() { }

	// RVA: 0xF1560 Offset: 0xF0960 VA: 0x1800F1560
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x1716EE0 Offset: 0x17154E0 VA: 0x181716EE0
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x2078E0 Offset: 0x206CE0 VA: 0x1802078E0 Slot: 4
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

