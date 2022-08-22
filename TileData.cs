public struct TileData // TypeDefIndex: 4572
{	// Fields
	private Sprite m_Sprite; // 0x0
	private Color m_Color; // 0x8
	private Matrix4x4 m_Transform; // 0x18
	private GameObject m_GameObject; // 0x58
	private TileFlags m_Flags; // 0x60
	private Tile.ColliderType m_ColliderType; // 0x64

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void set_sprite(Sprite value) { }

	// RVA: 0x116F30 Offset: 0x116330 VA: 0x180116F30
	public void set_color(Color value) { }

	// RVA: 0x240C90 Offset: 0x240090 VA: 0x180240C90
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0xF3780 Offset: 0xF2B80 VA: 0x1800F3780
	public void set_gameObject(GameObject value) { }

	// RVA: 0x23C140 Offset: 0x23B540 VA: 0x18023C140
	public void set_flags(TileFlags value) { }

	// RVA: 0x23C090 Offset: 0x23B490 VA: 0x18023C090
	public void set_colliderType(Tile.ColliderType value) { }

}

