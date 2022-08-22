public class ArcadeEntityController : BaseMonoBehaviour // TypeDefIndex: 8760
{	// Fields
	public BaseArcadeGame parentGame; // 0x18
	public ArcadeEntity arcadeEntity; // 0x20
	public ArcadeEntity sourceEntity; // 0x28
	private bool authorative; // 0x30

	// Properties
	public Vector3 heading { get; set; }
	public Vector3 positionLocal { get; set; }
	public Vector3 positionWorld { get; set; }

	// Methods

	// RVA: 0x82CA10 Offset: 0x82B010 VA: 0x18082CA10
	public Vector3 get_heading() { }

	// RVA: 0x82CAE0 Offset: 0x82B0E0 VA: 0x18082CAE0
	public void set_heading(Vector3 value) { }

	// RVA: 0x82CA40 Offset: 0x82B040 VA: 0x18082CA40
	public Vector3 get_positionLocal() { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x82CA90 Offset: 0x82B090 VA: 0x18082CA90
	public Vector3 get_positionWorld() { }

	// RVA: 0x82CB60 Offset: 0x82B160 VA: 0x18082CB60
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x82C490 Offset: 0x82AA90 VA: 0x18082C490
	public void SetOwnerGame(BaseArcadeGame ownerGame) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void Initialize() { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool IsAuthorative() { }

	// RVA: 0x82C320 Offset: 0x82A920 VA: 0x18082C320
	public void SetAuthorative(bool wants) { }

	// RVA: 0x82C940 Offset: 0x82AF40 VA: 0x18082C940
	public void SetSprite(Sprite newSprite) { }

	// RVA: 0x82C990 Offset: 0x82AF90 VA: 0x18082C990 Slot: 7
	public virtual void Shutdown() { }

	// RVA: 0x82C890 Offset: 0x82AE90 VA: 0x18082C890
	public void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x82C330 Offset: 0x82A930 VA: 0x18082C330
	public void SetHeading(Vector3 heading) { }

	// RVA: 0x82C820 Offset: 0x82AE20 VA: 0x18082C820
	public void SetPositionLocal(Vector3 newPos) { }

	// RVA: 0x82C300 Offset: 0x82A900 VA: 0x18082C300
	public void OnDisable() { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

