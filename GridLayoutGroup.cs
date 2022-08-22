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

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x15DE5C0 Offset: 0x15DCBC0 VA: 0x1815DE5C0
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x15DE570 Offset: 0x15DCB70 VA: 0x1815DE570
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x15DE3C0 Offset: 0x15DC9C0 VA: 0x1815DE3C0
	public Vector2 get_cellSize() { }

	// RVA: 0x15DE400 Offset: 0x15DCA00 VA: 0x1815DE400
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x15DE3E0 Offset: 0x15DC9E0 VA: 0x1815DE3E0
	public Vector2 get_spacing() { }

	// RVA: 0x15DE520 Offset: 0x15DCB20 VA: 0x1815DE520
	public void set_spacing(Vector2 value) { }

	// RVA: 0x804110 Offset: 0x802710 VA: 0x180804110
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x15DE4D0 Offset: 0x15DCAD0 VA: 0x1815DE4D0
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0xB29340 Offset: 0xB27940 VA: 0x180B29340
	public int get_constraintCount() { }

	// RVA: 0x15DE450 Offset: 0x15DCA50 VA: 0x1815DE450
	public void set_constraintCount(int value) { }

	// RVA: 0x15DE310 Offset: 0x15DC910 VA: 0x1815DE310
	protected void .ctor() { }

	// RVA: 0x15DD7E0 Offset: 0x15DBDE0 VA: 0x1815DD7E0 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15DD9A0 Offset: 0x15DBFA0 VA: 0x1815DD9A0 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x15DE2F0 Offset: 0x15DC8F0 VA: 0x1815DE2F0 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x15DE300 Offset: 0x15DC900 VA: 0x1815DE300 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x15DDBC0 Offset: 0x15DC1C0 VA: 0x1815DDBC0
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

