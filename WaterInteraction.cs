public class WaterInteraction : MonoBehaviour // TypeDefIndex: 10616
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Texture2D texture; // 0x18
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Displacement; // 0x20
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Disturbance; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WaterDynamics.Image <Image>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <Position>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <Scale>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0xC157E0 Offset: 0xC13DE0 VA: 0x180C157E0
	public void set_Texture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public WaterDynamics.Image get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	private void set_Image(WaterDynamics.Image value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC15780 Offset: 0xC13D80 VA: 0x180C15780
	public Vector2 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC157C0 Offset: 0xC13DC0 VA: 0x180C157C0
	private void set_Position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC157A0 Offset: 0xC13DA0 VA: 0x180C157A0
	public Vector2 get_Scale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC157D0 Offset: 0xC13DD0 VA: 0x180C157D0
	private void set_Scale(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533DF0 Offset: 0x5323F0 VA: 0x180533DF0
	public float get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E00 Offset: 0x532400 VA: 0x180533E00
	private void set_Rotation(float value) { }

	// RVA: 0xC15190 Offset: 0xC13790 VA: 0x180C15190
	protected void OnEnable() { }

	// RVA: 0xC15180 Offset: 0xC13780 VA: 0x180C15180
	protected void OnDisable() { }

	// RVA: 0xC15000 Offset: 0xC13600 VA: 0x180C15000
	public void CheckRegister() { }

	// RVA: 0xC15490 Offset: 0xC13A90 VA: 0x180C15490
	private void UpdateImage() { }

	// RVA: 0xC15360 Offset: 0xC13960 VA: 0x180C15360
	private void Register() { }

	// RVA: 0xC15410 Offset: 0xC13A10 VA: 0x180C15410
	private void Unregister() { }

	// RVA: 0xC15500 Offset: 0xC13B00 VA: 0x180C15500
	public void UpdateTransform() { }

	// RVA: 0xC156D0 Offset: 0xC13CD0 VA: 0x180C156D0
	public void .ctor() { }

}

