public class BaseBulb : MonoBehaviour // TypeDefIndex: 8824
{	// Fields
	public Renderer bulbRenderer; // 0x18
	private static readonly int timeOffsetHash; // 0x0
	private static readonly int bulbIndexHash; // 0x4
	private static readonly int modeHash; // 0x8
	private AdvancedChristmasLights.AnimationType currentAnimationType; // 0x20
	private float timeOffset; // 0x24
	private int bulbIndex; // 0x28
	private bool isOn; // 0x2C
	private MaterialPropertyBlock materialPropertyBlock; // 0x30

	// Methods

	// RVA: 0x7D6A40 Offset: 0x7D5040 VA: 0x1807D6A40 Slot: 4
	public virtual void SetOn(bool wantsOn) { }

	// RVA: 0x7D6A50 Offset: 0x7D5050 VA: 0x1807D6A50 Slot: 5
	public virtual void SetSpacingIndex(float timeOffset, int bulbIndex) { }

	// RVA: 0x7D6A30 Offset: 0x7D5030 VA: 0x1807D6A30 Slot: 6
	public virtual void SetBulbAnimation(AdvancedChristmasLights.AnimationType type) { }

	// RVA: 0x7D6A60 Offset: 0x7D5060 VA: 0x1807D6A60
	private void UpdateMaterialProperties() { }

	// RVA: 0x7D6C20 Offset: 0x7D5220 VA: 0x1807D6C20
	public void .ctor() { }

	// RVA: 0x7D6BA0 Offset: 0x7D51A0 VA: 0x1807D6BA0
	private static void .cctor() { }

}

