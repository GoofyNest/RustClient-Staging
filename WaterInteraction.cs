public class WaterInteraction : MonoBehaviour // TypeDefIndex: 10616
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Texture2D texture; // 0x18
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float Displacement; // 0x20
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float Disturbance; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private WaterDynamics.Image <Image>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 <Position>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2 <Scale>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Rotation>k__BackingField; // 0x40
	private Transform cachedTransform; // 0x48

	// Properties
	public Texture2D Texture { get; set; }
	public WaterDynamics.Image Image { get; set; }
	public Vector2 Position { get; set; }
	public Vector2 Scale { get; set; }
	public float Rotation { get; set; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Texture2D get_Texture() { }

	// RVA: 0xC15050 Offset: 0xC13650 VA: 0x180C15050
	public void set_Texture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public WaterDynamics.Image get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_Image(WaterDynamics.Image value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC14FF0 Offset: 0xC135F0 VA: 0x180C14FF0
	public Vector2 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC15030 Offset: 0xC13630 VA: 0x180C15030
	private void set_Position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC15010 Offset: 0xC13610 VA: 0x180C15010
	public Vector2 get_Scale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC15040 Offset: 0xC13640 VA: 0x180C15040
	private void set_Scale(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	private void set_Rotation(float value) { }

	// RVA: 0xC14A00 Offset: 0xC13000 VA: 0x180C14A00
	protected void OnEnable() { }

	// RVA: 0xC149F0 Offset: 0xC12FF0 VA: 0x180C149F0
	protected void OnDisable() { }

	// RVA: 0xC14870 Offset: 0xC12E70 VA: 0x180C14870
	public void CheckRegister() { }

	// RVA: 0xC14D00 Offset: 0xC13300 VA: 0x180C14D00
	private void UpdateImage() { }

	// RVA: 0xC14BD0 Offset: 0xC131D0 VA: 0x180C14BD0
	private void Register() { }

	// RVA: 0xC14C80 Offset: 0xC13280 VA: 0x180C14C80
	private void Unregister() { }

	// RVA: 0xC14D70 Offset: 0xC13370 VA: 0x180C14D70
	public void UpdateTransform() { }

	// RVA: 0xC14F40 Offset: 0xC13540 VA: 0x180C14F40
	public void .ctor() { }

}

