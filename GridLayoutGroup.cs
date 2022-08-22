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

	// RVA: 0xAE97E0 Offset: 0xAE7DE0 VA: 0x180AE97E0
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x15F0FE0 Offset: 0x15EF5E0 VA: 0x1815F0FE0
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x15F0F90 Offset: 0x15EF590 VA: 0x1815F0F90
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x15F0DE0 Offset: 0x15EF3E0 VA: 0x1815F0DE0
	public Vector2 get_cellSize() { }

	// RVA: 0x15F0E20 Offset: 0x15EF420 VA: 0x1815F0E20
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x15F0E00 Offset: 0x15EF400 VA: 0x1815F0E00
	public Vector2 get_spacing() { }

	// RVA: 0x15F0F40 Offset: 0x15EF540 VA: 0x1815F0F40
	public void set_spacing(Vector2 value) { }

	// RVA: 0x803A70 Offset: 0x802070 VA: 0x180803A70
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x15F0EF0 Offset: 0x15EF4F0 VA: 0x1815F0EF0
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0xB28BB0 Offset: 0xB271B0 VA: 0x180B28BB0
	public int get_constraintCount() { }

	// RVA: 0x15F0E70 Offset: 0x15EF470 VA: 0x1815F0E70
	public void set_constraintCount(int value) { }

	// RVA: 0x15F0D30 Offset: 0x15EF330 VA: 0x1815F0D30
	protected void .ctor() { }

	// RVA: 0x15F0200 Offset: 0x15EE800 VA: 0x1815F0200 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15F03C0 Offset: 0x15EE9C0 VA: 0x1815F03C0 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x15F0D10 Offset: 0x15EF310 VA: 0x1815F0D10 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x15F0D20 Offset: 0x15EF320 VA: 0x1815F0D20 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x15F05E0 Offset: 0x15EEBE0 VA: 0x1815F05E0
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

