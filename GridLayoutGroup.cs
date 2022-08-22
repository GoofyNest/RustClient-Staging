public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 4965
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected GridLayoutGroup.Corner m_StartCorner; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected GridLayoutGroup.Axis m_StartAxis; // 0x5C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Vector2 m_CellSize; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Vector2 m_Spacing; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected GridLayoutGroup.Constraint m_Constraint; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected int m_ConstraintCount; // 0x74

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x15F12A0 Offset: 0x15EF8A0 VA: 0x1815F12A0
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x15F1250 Offset: 0x15EF850 VA: 0x1815F1250
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x15F10A0 Offset: 0x15EF6A0 VA: 0x1815F10A0
	public Vector2 get_cellSize() { }

	// RVA: 0x15F10E0 Offset: 0x15EF6E0 VA: 0x1815F10E0
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x15F10C0 Offset: 0x15EF6C0 VA: 0x1815F10C0
	public Vector2 get_spacing() { }

	// RVA: 0x15F1200 Offset: 0x15EF800 VA: 0x1815F1200
	public void set_spacing(Vector2 value) { }

	// RVA: 0x803B80 Offset: 0x802180 VA: 0x180803B80
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x15F11B0 Offset: 0x15EF7B0 VA: 0x1815F11B0
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0xB28E70 Offset: 0xB27470 VA: 0x180B28E70
	public int get_constraintCount() { }

	// RVA: 0x15F1130 Offset: 0x15EF730 VA: 0x1815F1130
	public void set_constraintCount(int value) { }

	// RVA: 0x15F0FF0 Offset: 0x15EF5F0 VA: 0x1815F0FF0
	protected void .ctor() { }

	// RVA: 0x15F04C0 Offset: 0x15EEAC0 VA: 0x1815F04C0 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15F0680 Offset: 0x15EEC80 VA: 0x1815F0680 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x15F0FD0 Offset: 0x15EF5D0 VA: 0x1815F0FD0 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x15F0FE0 Offset: 0x15EF5E0 VA: 0x1815F0FE0 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x15F08A0 Offset: 0x15EEEA0 VA: 0x1815F08A0
	private void SetCellsAlongAxis(int axis) { }

}

public enum GridLayoutGroup.Corner // TypeDefIndex: 4966
{	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Corner UpperLeft = 0;
	public const GridLayoutGroup.Corner UpperRight = 1;
	public const GridLayoutGroup.Corner LowerLeft = 2;
	public const GridLayoutGroup.Corner LowerRight = 3;

}

public enum GridLayoutGroup.Axis // TypeDefIndex: 4967
{	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Axis Horizontal = 0;
	public const GridLayoutGroup.Axis Vertical = 1;

}

public enum GridLayoutGroup.Constraint // TypeDefIndex: 4968
{	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Constraint Flexible = 0;
	public const GridLayoutGroup.Constraint FixedColumnCount = 1;
	public const GridLayoutGroup.Constraint FixedRowCount = 2;

}

