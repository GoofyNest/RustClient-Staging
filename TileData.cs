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

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	public void set_sprite(Sprite value) { }

	// RVA: 0x116FB0 Offset: 0x1163B0 VA: 0x180116FB0
	public void set_color(Color value) { }

	// RVA: 0x240D10 Offset: 0x240110 VA: 0x180240D10
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0xF3800 Offset: 0xF2C00 VA: 0x1800F3800
	public void set_gameObject(GameObject value) { }

	// RVA: 0x23C1C0 Offset: 0x23B5C0 VA: 0x18023C1C0
	public void set_flags(TileFlags value) { }

	// RVA: 0x23C110 Offset: 0x23B510 VA: 0x18023C110
	public void set_colliderType(Tile.ColliderType value) { }

}

